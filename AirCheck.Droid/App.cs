using AirCheck.Droid.Views;
using Xamarin.Forms;

namespace AirCheck.Droid
{
    public class App : Application
    {
        public App()
        {
            MainPage = new AppPage();
        }

        public void RegisterTypes()
        {
            //RegisterType<IDeviceLocationService, DeviceLocationService>();
        }
    }
}