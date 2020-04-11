using Tizen.Wearable.CircularUI.Forms.Renderer;
using Xamarin.Forms;

namespace AirCheck.Tizen
{
    class Program : Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var program = new Program();
            Forms.Init(program);
            FormsCircularUI.Init();
            program.Run(args);
        }
    }
}
