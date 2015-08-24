using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace ListView.ExpandingFooter.Droid
{
    [Activity(Label = "ListView.ExpandingFooter", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);

            var dimensions = GetDimensions();
            App.SetScreenDimensions(dimensions.Item1, dimensions.Item2);

            LoadApplication(new App());
        }

        private Tuple<float,float> GetDimensions()
        {
            var displaymetrics = new DisplayMetrics();
            WindowManager.DefaultDisplay.GetMetrics(displaymetrics);
            var height = (displaymetrics.HeightPixels/displaymetrics.Density);
            var width = displaymetrics.WidthPixels / displaymetrics.Density;
            
            return new Tuple<float, float>(height,width);
        }
    }
}

