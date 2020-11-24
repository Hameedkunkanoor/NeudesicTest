using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Forms.Platforms.Android.Views;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
namespace NeudesicTest.Droid
{
    [Activity(
    Label = "NeudesicTest"
    , MainLauncher = true
    , Theme = "@style/NeudesicTestTheme.Splash"
    , NoHistory = true
    , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreenActivity : MvxFormsSplashScreenAppCompatActivity<Setup, CoreApp, App>
    {
        public SplashScreenActivity()
            : base(Resource.Layout.SplashScreen)
        {
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);
}

        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            Xamarin.Essentials.Platform.Init(this, bundle);
            base.OnCreate(bundle);
            Forms.ViewInitialized += (object sender, ViewInitializedEventArgs e) =>
            {
                if (!string.IsNullOrWhiteSpace(e.View.StyleId))
                {
                    e.NativeView.ContentDescription = e.View.StyleId;
                }
            };





        }
        protected override Task RunAppStartAsync(Bundle bundle)
        {
            StartActivity(typeof(FormsApplicationActivity));
            return Task.CompletedTask;
        }
    }
}
