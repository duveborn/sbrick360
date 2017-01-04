using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.GenericAttributeProfile;

namespace FlowersFX.SBrick360.Integration.SBrick
{
    public class SBrickService
    {
        private const string SbrickRemoteControlServiceGuid = "4dc591b0-857c-41de-b5f1-15abda665b0c";
        private const string SbrickRemoteControlCharacteristicGuid = "02b8cbcc-0e25-4bda-8790-a15f53e6010f";

        public async Task<List<Sbrick>> GetDevices()
        {
            var devices = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(GattDeviceService.GetDeviceSelectorFromUuid(new Guid(SbrickRemoteControlServiceGuid)));

            if (devices.Count == 0)
            {
                return null;
            }

            var sbricks = new List<Sbrick>(devices.Count);

            for (var index = 0; index < devices.Count; index++)
            {
                var service = await GattDeviceService.FromIdAsync(devices[index].Id);
                sbricks.Add(new Sbrick(devices[index].Name, service.DeviceId, index + 1, GetRemoteControl(service), index, devices[index], service));
            }

            return sbricks;
        }

        private RemoteControl GetRemoteControl(GattDeviceService service)
        {
            var characteristics = service.GetCharacteristics(new Guid(SbrickRemoteControlCharacteristicGuid));

            if (characteristics.Count == 0)
            {
                return null;
            }

            var remoteControl = new RemoteControl(characteristics[0]);

            return remoteControl;
        }
    }
}
