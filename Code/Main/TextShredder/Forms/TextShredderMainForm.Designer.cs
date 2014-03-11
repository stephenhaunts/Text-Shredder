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
namespace HauntedHouseSoftware.TextShredder
{
    partial class TextShredderMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextShredderMainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.encryptionDecryptionTabPage = new System.Windows.Forms.TabControl();
            this.EncryptionTab = new System.Windows.Forms.TabPage();
            this.copytoClipBoard = new System.Windows.Forms.Button();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.encryptedTextLabel = new System.Windows.Forms.Label();
            this.textToEncryptLabel = new System.Windows.Forms.Label();
            this.textToEncrypt = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.DecryptionTab = new System.Windows.Forms.TabPage();
            this.pasteFromClipboard = new System.Windows.Forms.Button();
            this.decryptedText = new System.Windows.Forms.TextBox();
            this.decryptedTextLabel = new System.Windows.Forms.Label();
            this.textToDecryptLabel = new System.Windows.Forms.Label();
            this.textToDecrypt = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copytoClipBoardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteFromClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowContrastDarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowContrastLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTextAfterEncrypt = new System.Windows.Forms.CheckBox();
            this.deletePlainText = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.encryptionDecryptionTabPage.SuspendLayout();
            this.EncryptionTab.SuspendLayout();
            this.DecryptionTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 543);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(838, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Text Shredder - Personal Encryption Tool";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // encryptionDecryptionTabPage
            // 
            this.encryptionDecryptionTabPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.encryptionDecryptionTabPage.Controls.Add(this.EncryptionTab);
            this.encryptionDecryptionTabPage.Controls.Add(this.DecryptionTab);
            this.encryptionDecryptionTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptionDecryptionTabPage.Location = new System.Drawing.Point(0, 24);
            this.encryptionDecryptionTabPage.Name = "encryptionDecryptionTabPage";
            this.encryptionDecryptionTabPage.SelectedIndex = 0;
            this.encryptionDecryptionTabPage.Size = new System.Drawing.Size(838, 519);
            this.encryptionDecryptionTabPage.TabIndex = 3;
            this.encryptionDecryptionTabPage.SelectedIndexChanged += new System.EventHandler(this.encryptionDecryptionTabPage_SelectedIndexChanged);
            // 
            // EncryptionTab
            // 
            this.EncryptionTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EncryptionTab.Controls.Add(this.deleteTextAfterEncrypt);
            this.EncryptionTab.Controls.Add(this.copytoClipBoard);
            this.EncryptionTab.Controls.Add(this.encryptedText);
            this.EncryptionTab.Controls.Add(this.encryptedTextLabel);
            this.EncryptionTab.Controls.Add(this.textToEncryptLabel);
            this.EncryptionTab.Controls.Add(this.textToEncrypt);
            this.EncryptionTab.Controls.Add(this.encryptButton);
            this.EncryptionTab.Location = new System.Drawing.Point(4, 4);
            this.EncryptionTab.Name = "EncryptionTab";
            this.EncryptionTab.Padding = new System.Windows.Forms.Padding(3);
            this.EncryptionTab.Size = new System.Drawing.Size(830, 493);
            this.EncryptionTab.TabIndex = 0;
            this.EncryptionTab.Text = "Encrypt";
            // 
            // copytoClipBoard
            // 
            this.copytoClipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copytoClipBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copytoClipBoard.Location = new System.Drawing.Point(9, 464);
            this.copytoClipBoard.Name = "copytoClipBoard";
            this.copytoClipBoard.Size = new System.Drawing.Size(157, 23);
            this.copytoClipBoard.TabIndex = 5;
            this.copytoClipBoard.Text = "Copy Encrypted to Clipboard";
            this.copytoClipBoard.UseVisualStyleBackColor = true;
            this.copytoClipBoard.Click += new System.EventHandler(this.copytoClipBoard_Click);
            // 
            // encryptedText
            // 
            this.encryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptedText.BackColor = System.Drawing.Color.White;
            this.encryptedText.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedText.Location = new System.Drawing.Point(9, 254);
            this.encryptedText.Multiline = true;
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.ReadOnly = true;
            this.encryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptedText.Size = new System.Drawing.Size(813, 205);
            this.encryptedText.TabIndex = 4;
            this.encryptedText.WordWrap = false;
            // 
            // encryptedTextLabel
            // 
            this.encryptedTextLabel.AutoSize = true;
            this.encryptedTextLabel.Location = new System.Drawing.Point(6, 238);
            this.encryptedTextLabel.Name = "encryptedTextLabel";
            this.encryptedTextLabel.Size = new System.Drawing.Size(79, 13);
            this.encryptedTextLabel.TabIndex = 3;
            this.encryptedTextLabel.Text = "Encrypted Text";
            // 
            // textToEncryptLabel
            // 
            this.textToEncryptLabel.AutoSize = true;
            this.textToEncryptLabel.Location = new System.Drawing.Point(6, 18);
            this.textToEncryptLabel.Name = "textToEncryptLabel";
            this.textToEncryptLabel.Size = new System.Drawing.Size(79, 13);
            this.textToEncryptLabel.TabIndex = 2;
            this.textToEncryptLabel.Text = "Text to Encrypt";
            // 
            // textToEncrypt
            // 
            this.textToEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textToEncrypt.BackColor = System.Drawing.Color.White;
            this.textToEncrypt.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToEncrypt.Location = new System.Drawing.Point(9, 34);
            this.textToEncrypt.Multiline = true;
            this.textToEncrypt.Name = "textToEncrypt";
            this.textToEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToEncrypt.Size = new System.Drawing.Size(813, 185);
            this.textToEncrypt.TabIndex = 1;
            this.textToEncrypt.WordWrap = false;
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Location = new System.Drawing.Point(747, 465);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // DecryptionTab
            // 
            this.DecryptionTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DecryptionTab.Controls.Add(this.deletePlainText);
            this.DecryptionTab.Controls.Add(this.pasteFromClipboard);
            this.DecryptionTab.Controls.Add(this.decryptedText);
            this.DecryptionTab.Controls.Add(this.decryptedTextLabel);
            this.DecryptionTab.Controls.Add(this.textToDecryptLabel);
            this.DecryptionTab.Controls.Add(this.textToDecrypt);
            this.DecryptionTab.Controls.Add(this.decryptButton);
            this.DecryptionTab.Location = new System.Drawing.Point(4, 4);
            this.DecryptionTab.Name = "DecryptionTab";
            this.DecryptionTab.Padding = new System.Windows.Forms.Padding(3);
            this.DecryptionTab.Size = new System.Drawing.Size(830, 493);
            this.DecryptionTab.TabIndex = 1;
            this.DecryptionTab.Text = "Decrypt";
            // 
            // pasteFromClipboard
            // 
            this.pasteFromClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pasteFromClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteFromClipboard.Location = new System.Drawing.Point(9, 464);
            this.pasteFromClipboard.Name = "pasteFromClipboard";
            this.pasteFromClipboard.Size = new System.Drawing.Size(190, 23);
            this.pasteFromClipboard.TabIndex = 9;
            this.pasteFromClipboard.Text = "Paste Encrypted Text from Clipboard";
            this.pasteFromClipboard.UseVisualStyleBackColor = true;
            this.pasteFromClipboard.Click += new System.EventHandler(this.pasteFromClipboard_Click);
            // 
            // decryptedText
            // 
            this.decryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptedText.BackColor = System.Drawing.Color.White;
            this.decryptedText.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedText.Location = new System.Drawing.Point(9, 254);
            this.decryptedText.Multiline = true;
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.ReadOnly = true;
            this.decryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptedText.Size = new System.Drawing.Size(813, 205);
            this.decryptedText.TabIndex = 8;
            this.decryptedText.WordWrap = false;
            // 
            // decryptedTextLabel
            // 
            this.decryptedTextLabel.AutoSize = true;
            this.decryptedTextLabel.Location = new System.Drawing.Point(6, 238);
            this.decryptedTextLabel.Name = "decryptedTextLabel";
            this.decryptedTextLabel.Size = new System.Drawing.Size(80, 13);
            this.decryptedTextLabel.TabIndex = 7;
            this.decryptedTextLabel.Text = "Decrypted Text";
            // 
            // textToDecryptLabel
            // 
            this.textToDecryptLabel.AutoSize = true;
            this.textToDecryptLabel.Location = new System.Drawing.Point(6, 18);
            this.textToDecryptLabel.Name = "textToDecryptLabel";
            this.textToDecryptLabel.Size = new System.Drawing.Size(80, 13);
            this.textToDecryptLabel.TabIndex = 6;
            this.textToDecryptLabel.Text = "Text to Decrypt";
            // 
            // textToDecrypt
            // 
            this.textToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textToDecrypt.BackColor = System.Drawing.Color.White;
            this.textToDecrypt.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToDecrypt.Location = new System.Drawing.Point(9, 34);
            this.textToDecrypt.Multiline = true;
            this.textToDecrypt.Name = "textToDecrypt";
            this.textToDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToDecrypt.Size = new System.Drawing.Size(813, 185);
            this.textToDecrypt.TabIndex = 5;
            this.textToDecrypt.WordWrap = false;
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Location = new System.Drawing.Point(747, 465);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // setPasswordToolStripMenuItem
            // 
            this.setPasswordToolStripMenuItem.Name = "setPasswordToolStripMenuItem";
            this.setPasswordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setPasswordToolStripMenuItem.Text = "Set Password";
            this.setPasswordToolStripMenuItem.Click += new System.EventHandler(this.setPasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptMenuItem,
            this.copytoClipBoardMenuItem});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            // 
            // encryptMenuItem
            // 
            this.encryptMenuItem.Name = "encryptMenuItem";
            this.encryptMenuItem.Size = new System.Drawing.Size(171, 22);
            this.encryptMenuItem.Text = "Encrypt";
            this.encryptMenuItem.Click += new System.EventHandler(this.encryptMenuItem_Click);
            // 
            // copytoClipBoardMenuItem
            // 
            this.copytoClipBoardMenuItem.Name = "copytoClipBoardMenuItem";
            this.copytoClipBoardMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copytoClipBoardMenuItem.Text = "Copy to Clipboard";
            this.copytoClipBoardMenuItem.Click += new System.EventHandler(this.copytoClipBoardMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptMenuItem,
            this.pasteFromClipboardMenuItem});
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // decryptMenuItem
            // 
            this.decryptMenuItem.Name = "decryptMenuItem";
            this.decryptMenuItem.Size = new System.Drawing.Size(186, 22);
            this.decryptMenuItem.Text = "Decrypt";
            this.decryptMenuItem.Click += new System.EventHandler(this.decryptMenuItem_Click);
            // 
            // pasteFromClipboardMenuItem
            // 
            this.pasteFromClipboardMenuItem.Name = "pasteFromClipboardMenuItem";
            this.pasteFromClipboardMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pasteFromClipboardMenuItem.Text = "Paste from Clipboard";
            this.pasteFromClipboardMenuItem.Click += new System.EventHandler(this.pasteFromClipboardMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.lowContrastDarkToolStripMenuItem,
            this.lowContrastLightToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // lowContrastDarkToolStripMenuItem
            // 
            this.lowContrastDarkToolStripMenuItem.Name = "lowContrastDarkToolStripMenuItem";
            this.lowContrastDarkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.lowContrastDarkToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.lowContrastDarkToolStripMenuItem.Text = "Low Contrast (Dark)";
            this.lowContrastDarkToolStripMenuItem.Click += new System.EventHandler(this.lowContrastDarkToolStripMenuItem_Click);
            // 
            // lowContrastLightToolStripMenuItem
            // 
            this.lowContrastLightToolStripMenuItem.Name = "lowContrastLightToolStripMenuItem";
            this.lowContrastLightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.lowContrastLightToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.lowContrastLightToolStripMenuItem.Text = "Low Contrast (Light)";
            this.lowContrastLightToolStripMenuItem.Click += new System.EventHandler(this.lowContrastLightToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // deleteTextAfterEncrypt
            // 
            this.deleteTextAfterEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteTextAfterEncrypt.AutoSize = true;
            this.deleteTextAfterEncrypt.Checked = true;
            this.deleteTextAfterEncrypt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteTextAfterEncrypt.Location = new System.Drawing.Point(180, 470);
            this.deleteTextAfterEncrypt.Name = "deleteTextAfterEncrypt";
            this.deleteTextAfterEncrypt.Size = new System.Drawing.Size(145, 17);
            this.deleteTextAfterEncrypt.TabIndex = 6;
            this.deleteTextAfterEncrypt.Text = "Delete Text After Encrypt";
            this.deleteTextAfterEncrypt.UseVisualStyleBackColor = true;
            this.deleteTextAfterEncrypt.CheckedChanged += new System.EventHandler(this.deleteTextAfterEncrypt_CheckedChanged);
            // 
            // deletePlainText
            // 
            this.deletePlainText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletePlainText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlainText.Location = new System.Drawing.Point(205, 464);
            this.deletePlainText.Name = "deletePlainText";
            this.deletePlainText.Size = new System.Drawing.Size(111, 23);
            this.deletePlainText.TabIndex = 10;
            this.deletePlainText.Text = "Delete Plain Text";
            this.deletePlainText.UseVisualStyleBackColor = true;
            this.deletePlainText.Click += new System.EventHandler(this.deletePlainText_Click);
            // 
            // TextShredderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 565);
            this.Controls.Add(this.encryptionDecryptionTabPage);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "TextShredderMainForm";
            this.Text = "Text Shredder - Personal Encryption Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextShredderMainForm_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.encryptionDecryptionTabPage.ResumeLayout(false);
            this.EncryptionTab.ResumeLayout(false);
            this.EncryptionTab.PerformLayout();
            this.DecryptionTab.ResumeLayout(false);
            this.DecryptionTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl encryptionDecryptionTabPage;
        private System.Windows.Forms.TabPage EncryptionTab;
        private System.Windows.Forms.TabPage DecryptionTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox textToEncrypt;
        private System.Windows.Forms.TextBox encryptedText;
        private System.Windows.Forms.Label encryptedTextLabel;
        private System.Windows.Forms.Label textToEncryptLabel;
        private System.Windows.Forms.TextBox decryptedText;
        private System.Windows.Forms.Label decryptedTextLabel;
        private System.Windows.Forms.Label textToDecryptLabel;
        private System.Windows.Forms.TextBox textToDecrypt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem setPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptMenuItem;
        private System.Windows.Forms.Button copytoClipBoard;
        private System.Windows.Forms.Button pasteFromClipboard;
        private System.Windows.Forms.ToolStripMenuItem copytoClipBoardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteFromClipboardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowContrastDarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowContrastLightToolStripMenuItem;
        private System.Windows.Forms.CheckBox deleteTextAfterEncrypt;
        private System.Windows.Forms.Button deletePlainText;
    }
}

