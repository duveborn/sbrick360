using System;
using System.Collections.Generic;
using System.Timers;
using FlowersFX.SBrick360.Integration.SBrick;
using XInputDotNetPure;

namespace FlowersFX.SBrick360.Integration.Gamepad
{
    public class GamepadPollingService
    {
        private List<Sbrick> sbricks;
        private readonly Action<int, Output, int> updateValues;
        private readonly Timer pollingTimer;

        // Should only handle gamepads and use sbrickservice for drive handling...
        public GamepadPollingService(List<Sbrick> sbricks, int commandRate, Action<int, Output, int> updateValues)
        {
            this.sbricks = sbricks;
            this.updateValues = updateValues;

            pollingTimer = new Timer(1000f / commandRate);
            pollingTimer.Elapsed += DoPoll;
            pollingTimer.Start();
        }

        public void ChangeInterval(int commandRate)
        {
            pollingTimer.Interval = 1000f / commandRate;
        }

        public void UpdateSbricks(List<Sbrick> updatedSbricks)
        {
            sbricks = updatedSbricks;
        }

        private void DoPoll(object state, ElapsedEventArgs elapsedEventArgs)
        {
            if (sbricks == null)
            {
                return;
            }

            foreach (var sbrick in sbricks)
            {
                var gamepadState = GamePad.GetState((PlayerIndex) sbrick.PlayerIndex);
                if (!gamepadState.IsConnected)
                {
                    continue;
                }

                HandleDrive(sbrick, gamepadState.ThumbSticks.Left.Y, gamepadState.ThumbSticks.Left.X, gamepadState.ThumbSticks.Right.Y, gamepadState.ThumbSticks.Right.X, -gamepadState.Triggers.Left + gamepadState.Triggers.Right);
            }
        }

        private void HandleDrive(Sbrick sbrick, float a, float b, float c, float d, float e)
        {
            // Both d and e are checked for the last motor output, use the largest absolute value found
            var highestInputForLastOutput = Math.Abs(d) < Math.Abs(e) ? e : d;

            updateValues(sbrick.Number, Output.A, (int)(a * 255));
            updateValues(sbrick.Number, Output.B, (int)(b * 255));
            updateValues(sbrick.Number, Output.C, (int)(c * 255));
            updateValues(sbrick.Number, Output.D, (int)(highestInputForLastOutput * 255));

            sbrick.RemoteControl.DriveAllAsync((int)(a * 255), (int)(b * 255), (int)(c * 255), (int)(highestInputForLastOutput * 255));
        }

        public void Stop()
        {
            pollingTimer.Stop();
        }
    }
}
