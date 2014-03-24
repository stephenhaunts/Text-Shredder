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
using System.Drawing;
using System.Windows.Forms;

namespace HauntedHouseSoftware.TextShredder.Forms
{
    public partial class TextShredderMainForm
    {
        public TextShredderMainForm()
        {
            InitializeComponent();
            Visible = true;

            LoadSettings();

            if (!_upgradeNotice.DontShowThisAgain)
            {
                _upgradeNotice.ShowDialog();
            }

            SetPasswordAndStatusBar(true);

            encryptMenuItem.Enabled = true;
            decryptMenuItem.Enabled = false;
            copytoClipBoardMenuItem.Enabled = true;            
            pasteFromClipboardMenuItem.Enabled = false;
            SetWordWrap();
        }           

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }        

        private void encryptButton_Click(object sender, EventArgs e)
        {
            EncryptText();

            if (_deleteTextAfterEncrypt)
            {
                textToEncrypt.Text = "";
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void decryptButton_Click(object sender, EventArgs e)
        {
            DecryptText();
        }    

        private void setPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPasswordAndStatusBar(true);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var aboutBox = new AboutDialogBox())
            {
                aboutBox.ShowDialog();
            }
        }

        private void encryptMenuItem_Click(object sender, EventArgs e)
        {
            EncryptText();
        }

        private void decryptMenuItem_Click(object sender, EventArgs e)
        {
            DecryptText();
        }

        private void encryptionDecryptionTabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (encryptionDecryptionTabPage.SelectedTab == encryptionDecryptionTabPage.TabPages["EncryptionTab"])
            {
                encryptMenuItem.Enabled = true;
                copytoClipBoard.Enabled = true;
                copytoClipBoardMenuItem.Enabled = true;
                decryptMenuItem.Enabled = false;
                textToDecrypt.Enabled = false;
                pasteFromClipboard.Enabled = false;
                pasteFromClipboardMenuItem.Enabled = false;
            }
            else if (encryptionDecryptionTabPage.SelectedTab == encryptionDecryptionTabPage.TabPages["DecryptionTab"])
            {
                encryptMenuItem.Enabled = false;
                copytoClipBoard.Enabled = false;
                copytoClipBoardMenuItem.Enabled = false;
                decryptMenuItem.Enabled = true;
                textToDecrypt.Enabled = true;
                pasteFromClipboard.Enabled = true;
                pasteFromClipboardMenuItem.Enabled = true;
            }
        }

        private void copytoClipBoard_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void pasteFromClipboard_Click(object sender, EventArgs e)
        {
            PasteFromClipboard();
        }

        private void pasteFromClipboardMenuItem_Click(object sender, EventArgs e)
        {
            PasteFromClipboard();
        }

        private void copytoClipBoardMenuItem_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textToEncrypt.BackColor = Color.White;
            textToEncrypt.ForeColor = Color.Black;

            encryptedText.BackColor = Color.White;
            encryptedText.ForeColor = Color.Black;

            decryptedText.BackColor = Color.White;
            decryptedText.ForeColor = Color.Black;

            textToDecrypt.BackColor = Color.White;
            textToDecrypt.ForeColor = Color.Black;
        }

        private void lowContrastDarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textToEncrypt.BackColor = Color.DimGray;
            textToEncrypt.ForeColor = Color.Gray;

            encryptedText.BackColor = Color.DimGray;
            encryptedText.ForeColor = Color.Gray;

            decryptedText.BackColor = Color.DimGray;
            decryptedText.ForeColor = Color.Gray;

            textToDecrypt.BackColor = Color.DimGray;
            textToDecrypt.ForeColor = Color.Gray;
        }

        private void lowContrastLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textToEncrypt.BackColor = Color.Gainsboro;
            textToEncrypt.ForeColor = Color.Silver;

            encryptedText.BackColor = Color.Gainsboro;
            encryptedText.ForeColor = Color.Silver;

            decryptedText.BackColor = Color.Gainsboro;
            decryptedText.ForeColor = Color.Silver;

            textToDecrypt.BackColor = Color.Gainsboro;
            textToDecrypt.ForeColor = Color.Silver;
        }

        private void TextShredderMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void deleteTextAfterEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            _deleteTextAfterEncrypt = deleteTextAfterEncrypt.Checked;
        }

        private void deletePlainText_Click(object sender, EventArgs e)
        {
            decryptedText.Text = "";
        }

        private void openTextFileToolStripButton_Click(object sender, EventArgs e)
        {
            OpenTextFile();
        }

        private void saveTextFileToolStripButton_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }

        private void changePasswordTextFileToolStripButton_Click(object sender, EventArgs e)
        {
            SetPasswordAndStatusBar(true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTextFile();
        }

        private void saveEncryptedTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            LoadHelpPage();
        }

        private void clearAllDecrypt_Click(object sender, EventArgs e)
        {
            textToDecrypt.Text = "";
            decryptedText.Text = "";
        }

        private void clearAllEncrypted_Click(object sender, EventArgs e)
        {
            textToEncrypt.Text = "";
            encryptedText.Text = "";
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWordWrap();
        }       
    }
}
