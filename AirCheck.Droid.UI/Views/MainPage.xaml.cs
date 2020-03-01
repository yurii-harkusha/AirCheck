using AirCheck.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirCheck.Droid.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}