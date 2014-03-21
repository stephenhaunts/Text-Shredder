namespace HauntedHouseSoftware.TextShredder.Forms
{
    partial class UpgradeNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpgradeNotice));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aboutBoxOkButton = new System.Windows.Forms.Button();
            this.doNotDoThisAgain = new System.Windows.Forms.CheckBox();
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
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(284, 149);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(292, 13);
            this.linkLabel.TabIndex = 7;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "http://stephenhaunts.com/projects/text-shredder/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text Shredder is now at Version 1.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "You must make sure the recipient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "of your messages is using the same";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "version! You can download it from :";
            // 
            // aboutBoxOkButton
            // 
            this.aboutBoxOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aboutBoxOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutBoxOkButton.Location = new System.Drawing.Point(502, 277);
            this.aboutBoxOkButton.Name = "aboutBoxOkButton";
            this.aboutBoxOkButton.Size = new System.Drawing.Size(75, 23);
            this.aboutBoxOkButton.TabIndex = 12;
            this.aboutBoxOkButton.Text = "Ok";
            this.aboutBoxOkButton.UseVisualStyleBackColor = true;
            // 
            // doNotDoThisAgain
            // 
            this.doNotDoThisAgain.AutoSize = true;
            this.doNotDoThisAgain.Location = new System.Drawing.Point(12, 283);
            this.doNotDoThisAgain.Name = "doNotDoThisAgain";
            this.doNotDoThisAgain.Size = new System.Drawing.Size(134, 17);
            this.doNotDoThisAgain.TabIndex = 13;
            this.doNotDoThisAgain.Text = "Do not show this again";
            this.doNotDoThisAgain.UseVisualStyleBackColor = true;
            this.doNotDoThisAgain.CheckedChanged += new System.EventHandler(this.doNotDoThisAgain_CheckedChanged);
            // 
            // UpgradeNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 312);
            this.ControlBox = false;
            this.Controls.Add(this.doNotDoThisAgain);
            this.Controls.Add(this.aboutBoxOkButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpgradeNotice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Shredder Upgrade Notice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.LinkLabel linkLabel;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aboutBoxOkButton;
        private System.Windows.Forms.CheckBox doNotDoThisAgain;
    }
}