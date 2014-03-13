using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace HauntedHouseSoftware.TextShredder.Forms
{
    public partial class AboutDialogBox : Form
    {
        public AboutDialogBox()
        {
            InitializeComponent();
        }

        private void AboutDialogBox_Load(object sender, EventArgs e)
        {
             
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(linkLabel.Text);
                Process.Start(sInfo);
            }
            catch
            {
                MessageBox.Show("There was an loading the specified link.", "Error loading Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
