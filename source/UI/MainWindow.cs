using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using FlowersFX.SBrick360.Integration.Gamepad;
using FlowersFX.SBrick360.Integration.SBrick;

namespace FlowersFX.SBrick360.UI
{
    public partial class MainWindow : Form
    {
        private readonly GamepadPollingService gamepadPollingService;
        private readonly SBrickService sBrickService;

        private const string NoSBricksPairedMessage = "Make sure you first pair one or more SBricks with Windows using ControlPanel";

        private int commandRate = 30;
        private List<Sbrick> sbricks;
        private Sbrick selectedSbrick;

        public MainWindow()
        {
            InitializeComponent();
            sBrickService = new SBrickService();
            gamepadPollingService = new GamepadPollingService(sbricks, commandRate, UpdateStatusDisplay);

            UpdateListOfSBricks();
        }

        private async void UpdateListOfSBricks()
        {
            sbricks = await sBrickService.GetDevices();

            if (sbricks == null)
            {
                SetStatusMessage(NoSBricksPairedMessage);
                return;
            }

            motorControlsPanel.Visible = false;
            sbricksListView.BeginUpdate();
            sbricksListView.Items.Clear();

            foreach (var sbrick in sbricks)
            {
                var sbrickItem = new ListViewItem(sbrick.Name + " " + sbrick.Number)
                {
                    Tag = sbrick
                };

                sbricksListView.Items.Add(sbrickItem);
            }

            sbricksListView.Items[0].Selected = true;
            sbricksListView.EndUpdate();

            gamepadPollingService.UpdateSbricks(sbricks);

            SetStatusMessage(string.Empty);
        }

        private void SetStatusMessage(string message)
        {
            statusMessageLabel.Text = message;
        }

        private void UpdateStatusDisplay(int sbrickNumber, Output output, int power)
        {
            if (selectedSbrick == null || selectedSbrick.Number != sbrickNumber)
            {
                return;
            }

            MethodInvoker update = delegate
            {
                switch (output)
                {
                    case Output.A:
                        motor0PowerTrackBar.Value = power;
                        motor0Value.Text = power.ToString(CultureInfo.InvariantCulture);
                        break;
                    case Output.B:
                        motor1PowerTrackBar.Value = power;
                        motor1Value.Text = power.ToString(CultureInfo.InvariantCulture);
                        break;
                    case Output.C:
                        motor2PowerTrackBar.Value = power;
                        motor2Value.Text = power.ToString(CultureInfo.InvariantCulture);
                        break;
                    case Output.D:
                        motor3PowerTrackBar.Value = power;
                        motor3Value.Text = power.ToString(CultureInfo.InvariantCulture);
                        break;
                }
            };

            try
            {
                Invoke(update);
            }
            catch (ObjectDisposedException)
            {
                // Should fix the timer callback thread issue instead
            }
        }

        private void sbricksListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sbricksListView.SelectedItems.Count == 0)
            {
                selectedSbrick = null;
                motorControlsPanel.Visible = selectedSbrick != null;
                return;
            }

            selectedSbrick = sbricksListView.SelectedItems[0].Tag as Sbrick;
            motorControlsPanel.Visible = selectedSbrick != null;

            if (selectedSbrick != null)
            {
                gamepadDropDownBox.SelectedIndex = selectedSbrick.PlayerIndex + 1;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var settingsWindow = new SettingsWindow(commandRate))
            {
                if (settingsWindow.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                commandRate = settingsWindow.CommandRate;
                gamepadPollingService.ChangeInterval(commandRate);
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            gamepadPollingService.Stop();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog(this);
        }
    }
}
