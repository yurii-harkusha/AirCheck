using AirCheck.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirCheck.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppPage : ContentPage
    {
        public AppPage()
        {
            InitializeComponent();
            this.BindingContext = new AppPageViewModel();
        }
    }
}