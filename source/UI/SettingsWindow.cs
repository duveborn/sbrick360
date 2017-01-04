using System.Windows.Forms;

namespace FlowersFX.SBrick360.UI
{
    public partial class SettingsWindow : Form
    {
        public int CommandRate { get; set; }

        public SettingsWindow(int commandRate)
        {
            InitializeComponent();
            commandRateUpDown.Value = CommandRate = commandRate;
        }

        private void cancelSettingsButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void saveSettingsButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            CommandRate = (int) commandRateUpDown.Value;
            Close();
        }
    }
}
