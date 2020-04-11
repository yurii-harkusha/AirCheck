using AirCheck.Core.Models.Location;
using AirCheck.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirCheck.Droid.Services
{
    public class DeviceLocationService : IDeviceLocationService
    {
        public Coordinates GetCurrentCoordinates()
        {
            return new Coordinates("","");
        }
    }
}