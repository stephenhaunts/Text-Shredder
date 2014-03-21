/**
* Text Shredder : A personal message encryption tool.
* 
* Copyright (C) 2014 Stephen Haunts
* http://www.stephenhaunts.com
* 
* This file is part of Text Shredder.
* 
* Text Shredder is free software: you can redistribute it and/or modify it under the terms of the
* GNU General Public License as published by the Free Software Foundation, either version 2 of the
* License, or (at your option) any later version.
* 
* Text Shredder is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* 
* See the GNU General Public License for more details <http://www.gnu.org/licenses/>.
* 
* Authors: Stephen Haunts
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using HauntedHouseSoftware.TextShredder.ClientLibrary;
using HauntedHouseSoftware.TextShredder.Forms;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;

namespace HauntedHouseSoftware.TextShredder
{
    public partial class TextShredderMainForm : Form
    {
        private bool _passwordSet;
        private PasswordEntry _passwordEntry;
        private ApplicationSettings _settings = new ApplicationSettings();
        private bool _deleteTextAfterEncrypt;
        private const string HELP_URL = "http://stephenhaunts.com/projects/text-shredder/text-shredder-1-0-manual/";

        private bool SetPassword(bool confirmPassword)
        {
            _passwordSet = false;

            while (!_passwordSet)
            {
                try
                {
                    using (_passwordEntry = new PasswordEntry())
                    {
                        _passwordEntry.LabelText = "Please enter your session password(s).";

                        if (_passwordEntry.ShowDialog() != DialogResult.OK)
                        {
                            return false;
                        }

                        if (confirmPassword)
                        {
                            if (ConfirmationPassword(_passwordEntry) == false)
                            {
                                return false;
                            }
                        }

                        _passwordSet = true;
                    }
                }
                catch (ArgumentNullException)
                {
                    Debug.WriteLine("Argument Null Exception Caught.");
                }
            }

            return true;
        }

        private static bool ConfirmationPassword(PasswordEntry passwordEntry)
        {
            using (var passwordEntry2 = new PasswordEntry())
            {
                passwordEntry2.LabelText = "Please confirm your session password(s).";

                if (passwordEntry2.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                bool password1Match = ByteHelpers.ByteArrayCompare(passwordEntry.Password.Password1, passwordEntry2.Password.Password1);
                bool password2Match = ByteHelpers.ByteArrayCompare(passwordEntry.Password.Password2, passwordEntry2.Password.Password2);

                if ((password1Match == false) || (password2Match == false))
                {
                    MessageBox.Show("The passwords do not match.", "The passwords do not match.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }

                return true;
            }
        }

        private void SetPasswordAndStatusBar(bool force)
        {
            if (force)
            {
                SetPassword();
            }
            else
            {
                if (!_passwordSet)
                {
                    SetPassword();
                }
            }
        }

        private void SetPassword()
        {
            if (SetPassword(true))
            {
                toolStripStatusLabel.Text = "Password Set";
            }
            else
            {
                toolStripStatusLabel.Text = "Password Not Set";
            }
        }

        private void EncryptText()
        {
            SetPasswordAndStatusBar(false);

            try
            {
                encryptedText.Text = BlockEncrypter.EncryptBlock(textToEncrypt.Text, _passwordEntry.Password.CombinedPasswords);
            }
            catch (Exception)
            {
                encryptedText.Text = "";
                MessageBox.Show("There was an error encrypting the message.", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DecryptText()
        {
            SetPasswordAndStatusBar(false);

            try
            {
                decryptedText.Text = BlockEncrypter.DecryptBlock(textToDecrypt.Text, _passwordEntry.Password.CombinedPasswords);
            }
            catch(CryptographicException ex)
            {
                decryptedText.Text = "";
                MessageBox.Show(ex.Message, "Message Tamper Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception)
            {
                decryptedText.Text = "";
                MessageBox.Show("There was an error decrypting the message.", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }        
        }
        private void PasteFromClipboard()
        {
            textToDecrypt.Text = Clipboard.GetText(TextDataFormat.Text);
        }

        private void CopyToClipboard()
        {
            try
            {
                Clipboard.SetText(encryptedText.Text);
            }
            catch (ArgumentNullException) { }
        }

        private void LoadSettings()
        {
            _settings = SettingsWriter.ReadSettingsFile();

            if (_settings != null)
            {
                Location = new Point(_settings.WindowPositionX, _settings.WindowPositionY);
                Size = new Size(_settings.WindowWidth, _settings.WindowHeight);

                if (_settings.FormWindowState == FormWindowState.Minimized)
                {
                    _settings.FormWindowState = FormWindowState.Maximized;
                }

                WindowState = _settings.FormWindowState;

                textToEncrypt.BackColor = Color.FromArgb(_settings.BackgroundColorRed, _settings.BackgroundColorGreen, _settings.BackgroundColorBlue);
                textToEncrypt.ForeColor = Color.FromArgb(_settings.ForegroundColorRed, _settings.ForegroundColorGreen, _settings.ForegroundColorBlue);

                encryptedText.BackColor = Color.FromArgb(_settings.BackgroundColorRed, _settings.BackgroundColorGreen, _settings.BackgroundColorBlue);
                encryptedText.ForeColor = Color.FromArgb(_settings.ForegroundColorRed, _settings.ForegroundColorGreen, _settings.ForegroundColorBlue);

                decryptedText.BackColor = Color.FromArgb(_settings.BackgroundColorRed, _settings.BackgroundColorGreen, _settings.BackgroundColorBlue);
                decryptedText.ForeColor = Color.FromArgb(_settings.ForegroundColorRed, _settings.ForegroundColorGreen, _settings.ForegroundColorBlue);

                textToDecrypt.BackColor = Color.FromArgb(_settings.BackgroundColorRed, _settings.BackgroundColorGreen, _settings.BackgroundColorBlue);
                textToDecrypt.ForeColor = Color.FromArgb(_settings.ForegroundColorRed, _settings.ForegroundColorGreen, _settings.ForegroundColorBlue);

                wordWrapToolStripMenuItem.Checked = _settings.WordWrap;
                _upgradeNotice.DontShowThisAgain = _settings.DisableUpgradeNoticeVersion11;
            }
            else
            {
                SaveSettings();
            }
        }

        private void SaveSettings()
        {
            if (_settings == null)
            {
                _settings = new ApplicationSettings();
            }

            _settings.WindowPositionX = Location.X;
            _settings.WindowPositionY = Location.Y;
            _settings.WindowHeight = Size.Height;
            _settings.WindowWidth = Size.Width;
            _settings.FormWindowState = WindowState;

            _settings.BackgroundColorRed = textToEncrypt.BackColor.R;
            _settings.BackgroundColorGreen = textToEncrypt.BackColor.G;
            _settings.BackgroundColorBlue = textToEncrypt.BackColor.B;

            _settings.ForegroundColorRed = textToEncrypt.ForeColor.R;
            _settings.ForegroundColorGreen = textToEncrypt.ForeColor.G;
            _settings.ForegroundColorBlue = textToEncrypt.ForeColor.B;

            _settings.WordWrap = wordWrapToolStripMenuItem.Checked;

            _settings.DisableUpgradeNoticeVersion11 = _upgradeNotice.DontShowThisAgain;
         
            SettingsWriter.WriteSettingsFile(_settings);
        }

        private void OpenTextFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textToEncrypt.Text = File.ReadAllText(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show(String.Format("There was an error reading from the file <{0}>", openFileDialog.FileName), "Error Reading from File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveTextFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, encryptedText.Text);
                }
                catch
                {
                    MessageBox.Show(String.Format("There was an error saving the file <{0}>", saveFileDialog.FileName), "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private static void LoadHelpPage()
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(HELP_URL);
                Process.Start(sInfo);
            }
            catch
            {
                MessageBox.Show("There was an loading the specified link.", "Error loading Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetWordWrap()
        {
            textToEncrypt.WordWrap = wordWrapToolStripMenuItem.Checked;
            encryptedText.WordWrap = wordWrapToolStripMenuItem.Checked;

            textToDecrypt.WordWrap = wordWrapToolStripMenuItem.Checked;
            decryptedText.WordWrap = wordWrapToolStripMenuItem.Checked;
        }      
    }
}