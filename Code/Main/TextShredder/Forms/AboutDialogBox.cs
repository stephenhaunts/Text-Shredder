using System;
using System.Diagnostics;
using System.Windows.Forms;
using HauntedHouseSoftware.TextShredder.Properties;

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
                var sInfo = new ProcessStartInfo(linkLabel.Text);
                Process.Start(sInfo);
            }
            catch
            {
                MessageBox.Show(Resources.AboutDialogBox_linkLabel_LinkClicked, Resources.AboutDialogBox_linkLabel_LinkClicked_Error_loading_Link, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
