using AirCheck.Core;
using AirCheck.Core.ViewModels;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms.Xaml;

namespace AirCheck.Tizen.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : CirclePage
    {
		public MainPage ()
		{
			InitializeComponent ();
            this.BindingContext = new MainPageViewModel();
        }
	}
}