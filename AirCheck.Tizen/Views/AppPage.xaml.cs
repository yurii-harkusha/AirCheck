using AirCheck.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirCheck.Tizen.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppPage : CirclePage
    {
		public AppPage ()
		{
			InitializeComponent ();
            this.BindingContext = new AppPageViewModel();
        }
	}
}