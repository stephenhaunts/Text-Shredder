namespace HauntedHouseSoftware.TextShredder.Forms
{
    partial class AboutDialogBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialogBox));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.aboutBoxNameLabel = new System.Windows.Forms.Label();
            this.aboutBoxVersionLabel = new System.Windows.Forms.Label();
            this.aboutBoxLicenseName = new System.Windows.Forms.Label();
            this.aboutBoxOkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(253, 256);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // aboutBoxNameLabel
            // 
            this.aboutBoxNameLabel.AutoSize = true;
            this.aboutBoxNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBoxNameLabel.Location = new System.Drawing.Point(271, 14);
            this.aboutBoxNameLabel.Name = "aboutBoxNameLabel";
            this.aboutBoxNameLabel.Size = new System.Drawing.Size(322, 50);
            this.aboutBoxNameLabel.TabIndex = 2;
            this.aboutBoxNameLabel.Text = "Text Shredder";
            // 
            // aboutBoxVersionLabel
            // 
            this.aboutBoxVersionLabel.AutoSize = true;
            this.aboutBoxVersionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBoxVersionLabel.Location = new System.Drawing.Point(367, 64);
            this.aboutBoxVersionLabel.Name = "aboutBoxVersionLabel";
            this.aboutBoxVersionLabel.Size = new System.Drawing.Size(112, 22);
            this.aboutBoxVersionLabel.TabIndex = 3;
            this.aboutBoxVersionLabel.Text = "Version 1.0";
            // 
            // aboutBoxLicenseName
            // 
            this.aboutBoxLicenseName.AutoSize = true;
            this.aboutBoxLicenseName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBoxLicenseName.Location = new System.Drawing.Point(286, 155);
            this.aboutBoxLicenseName.Name = "aboutBoxLicenseName";
            this.aboutBoxLicenseName.Size = new System.Drawing.Size(295, 18);
            this.aboutBoxLicenseName.TabIndex = 4;
            this.aboutBoxLicenseName.Text = "Released under GNU Public License";
            // 
            // aboutBoxOkButton
            // 
            this.aboutBoxOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aboutBoxOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutBoxOkButton.Location = new System.Drawing.Point(506, 284);
            this.aboutBoxOkButton.Name = "aboutBoxOkButton";
            this.aboutBoxOkButton.Size = new System.Drawing.Size(75, 23);
            this.aboutBoxOkButton.TabIndex = 5;
            this.aboutBoxOkButton.Text = "Ok";
            this.aboutBoxOkButton.UseVisualStyleBackColor = true;
            // 
            // AboutDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 319);
            this.Controls.Add(this.aboutBoxOkButton);
            this.Controls.Add(this.aboutBoxLicenseName);
            this.Controls.Add(this.aboutBoxVersionLabel);
            this.Controls.Add(this.aboutBoxNameLabel);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Shredder - Personal Encryption Tool";
            this.Load += new System.EventHandler(this.AboutDialogBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label aboutBoxNameLabel;
        private System.Windows.Forms.Label aboutBoxVersionLabel;
        private System.Windows.Forms.Label aboutBoxLicenseName;
        private System.Windows.Forms.Button aboutBoxOkButton;
    }
}