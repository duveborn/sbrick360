using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FlowersFX.SBrick360.UI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            productNameLabel.Text = String.Format("SBrick360 {0}", version);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.flowersfx.com/");
            Process.Start(sInfo);
        }

        private void closeAboutDialogButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
