using ListView.ExpandingFooter.Pages;
using Xamarin.Forms;

namespace ListView.ExpandingFooter
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new RootPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static void SetScreenDimensions(float height, float width)
        {
            Device.Width = width;
            Device.Height = height;
        }

        public class Device
        {
            public static float Height { get; set; }
            public static float Width { get; set; }

            public static float StatusBarHeight
            {
                get
                {
                    switch (Xamarin.Forms.Device.OS)
                    {
                        case TargetPlatform.Android:
                            return 25; // 25 seems to be the standard height.
                        default:
                            return 0;
                    }
                }
            }
        }
    }
}
