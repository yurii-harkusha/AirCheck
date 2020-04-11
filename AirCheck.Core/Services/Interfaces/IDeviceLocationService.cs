using AirCheck.Core.Models.Location;

namespace AirCheck.Core.Services.Interfaces
{
    public interface IDeviceLocationService
    {
        Coordinates GetCurrentCoordinates();
    }
}
