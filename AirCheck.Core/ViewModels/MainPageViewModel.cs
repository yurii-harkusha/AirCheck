using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;

namespace AirCheck.Core.ViewModels
{
    public class MainPageViewModel: BaseViewModel
    {
        public Command GetAirInfoByIpCommand = new Command(GetAirInfoByIpCommandExecute);

        private static void GetAirInfoByIpCommandExecute(object obj)
        {
            
        }

        public MainPageViewModel()
        {

        }
    }
}
