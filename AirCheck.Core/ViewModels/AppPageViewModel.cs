using Xamarin.Forms;
using System.Threading.Tasks;
using AirCheck.Core.Services.Interfaces;

namespace AirCheck.Core.ViewModels
{
    public class AppPageViewModel: BaseViewModel
    {
        public AppPageViewModel()
        {
            GetAirInfoByIpCommand = new Command(async () => await GetAirInfoByIpCommandExecute());
        }


        public Command GetAirInfoByIpCommand { get; set; }

        private static Task GetAirInfoByIpCommandExecute()
        {
            var deviceLocationService = DependencyService.Resolve<IDeviceLocationService>();
            var location = deviceLocationService.GetCurrentCoordinates();
            return Task.Delay(100);
        }
    }
}
