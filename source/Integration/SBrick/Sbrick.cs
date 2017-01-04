using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;

namespace FlowersFX.SBrick360.Integration.SBrick
{
    public class Sbrick
    {
        public DeviceInformation DeviceInformation { get; private set; }
        public GattDeviceService Service { get; private set; }
        public string Name { get; private set; }
        public string DeviceId { get; private set; }
        public int Number { get; private set; }
        public RemoteControl RemoteControl { get; private set; }
        public int PlayerIndex { get; set; }

        public Sbrick(string name, string deviceId, int number, RemoteControl remoteControl, int playerIndex, DeviceInformation deviceInformation, GattDeviceService service)
        {
            DeviceInformation = deviceInformation;
            Service = service;
            Name = name;
            DeviceId = deviceId;
            Number = number;
            RemoteControl = remoteControl;
            PlayerIndex = playerIndex;
        }
    }
}