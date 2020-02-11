using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using AirCheck.Droid.Renderers.Controls;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Text;
using Android.Views;
using Android.Widget;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PopupEntry), typeof(CustomEntryRenderer))]
namespace AirCheck.Droid.Renderers.Controls
{
    class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null && this.Element != null)
            {
                Control.SetBackground(AddLine());
            }
        }

        public LayerDrawable AddLine()
        {
            ColorDrawable borderColorDrawable = new ColorDrawable(Android.Graphics.Color.White);
            ColorDrawable backgroundColorDrawable = new ColorDrawable(Android.Graphics.Color.Transparent);

            Drawable[] drawables = new Drawable[]
            {
                borderColorDrawable, backgroundColorDrawable
            };

            LayerDrawable layerDrawable = new LayerDrawable(drawables);
            layerDrawable.SetLayerInset(1, 0, 0, 0, 5);

            return layerDrawable;
        }
    }
}