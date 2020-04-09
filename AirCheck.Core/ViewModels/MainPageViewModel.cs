using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;

namespace AirCheck.Core.ViewModels
{
    public class MainPageViewModel: BaseViewModel
    {
        public MainPageViewModel()
        {
            GetAirInfoByIpCommand = new Command(async () => await GetAirInfoByIpCommandExecute());
        }

        public Command GetAirInfoByIpCommand { get; set; }

        private static Task GetAirInfoByIpCommandExecute()
        {
            return Task.Delay(100);
        }
    }
}
