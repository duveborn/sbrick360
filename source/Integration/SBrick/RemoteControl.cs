using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Bluetooth.GenericAttributeProfile;

namespace FlowersFX.SBrick360.Integration.SBrick
{
    public class RemoteControl
    {
        // SBrick firmware versions
        // 4.0 when a channel is set to full power, it cuts power instead. Apps must work
        // around this by sending "almost full power" (254) instead of "full power" (255).
        // 4.1 fixed motor power issue and now multiple motor commands can be sent in a
        // single command (improves throughput a lot)
        // https://social.sbrick.com/wiki/view/pageId/14/slug/hardware-and-firmware-versions
        private int firmwareVersion = 41; // TODO: Set firmware version by querying SBrick

        private readonly GattCharacteristic characteristic;

        private List<int> lastPower;
        private bool blockCommands;
 
        public RemoteControl(GattCharacteristic characteristic)
        {
            this.characteristic = characteristic;
            lastPower = new List<int> {0, 0, 0, 0};
        }

        public async void DriveAsync(Output output, int power)
        {
            if (lastPower[(int) output] == power || blockCommands)
            {
                return;
            }

            blockCommands = true;

            var direction = power < 0 ? 0 : 1;
            var driveCommand = new byte[] { 01, (byte)output, (byte)direction, (byte)GetAbsolutePower(power) };

            try
            {
                var status = await characteristic.WriteValueAsync(driveCommand.AsBuffer());

                if (status == GattCommunicationStatus.Success)
                {
                    lastPower[(int)output] = power;
                    blockCommands = false;
                }

                if (status == GattCommunicationStatus.Unreachable)
                {
                    // ...
                }
            }
            catch (Exception ex)
            {
                // TODO: Signal error to user
                blockCommands = true;
            }
        }

        public async void DriveAllAsync(int a, int b, int c, int d)
        {
            if (blockCommands)
            {
                return;
            }

            blockCommands = true;

            var driveCommand = new List<byte> { 01 };
            if (lastPower[0] != a)
            {
                driveCommand.AddRange(new List<byte>{00, (byte) (a < 0 ? 0 : 1), (byte) GetAbsolutePower(a)});
                lastPower[0] = a;
            }

            if (lastPower[1] != b)
            {
                driveCommand.AddRange(new List<byte>{01, (byte) (b < 0 ? 0 : 1), (byte) GetAbsolutePower(b)});
                lastPower[1] = b;
            }

            if (lastPower[2] != c)
            {
                driveCommand.AddRange(new List<byte>{02, (byte) (c < 0 ? 0 : 1), (byte) GetAbsolutePower(c)});
                lastPower[2] = c;
            }

            if (lastPower[3] != d)
            {
                driveCommand.AddRange(new List<byte>{03, (byte) (d < 0 ? 0 : 1), (byte) GetAbsolutePower(d)});
                lastPower[3] = d;
            }

            try
            {
                var status = await characteristic.WriteValueAsync(driveCommand.ToArray().AsBuffer());
                blockCommands = false;

                if (status == GattCommunicationStatus.Success)
                {
                    // ...
                }

                if (status == GattCommunicationStatus.Unreachable)
                {
                    // ...
                }
            }
            catch (Exception ex)
            {
                // TODO: Signal error to user
                blockCommands = true;
            }
        }

        private int GetAbsolutePower(int power)
        {
            var absolutePower = Math.Abs(power);
            if (absolutePower <= 254)
            {
                return absolutePower;
            }

            absolutePower = firmwareVersion <= 40 ? 254 : 255;
            return absolutePower;
        }
    }
}