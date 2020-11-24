using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Forms.Platforms.Android.Views;
using Xamarin.Forms;

namespace NeudesicTest.Droid
{
    [Activity(Label = "FormsApplicationActivity",
              ScreenOrientation = ScreenOrientation.Portrait,
              Theme = "@style/MyTheme",
              LaunchMode = LaunchMode.SingleTask)]
    public class FormsApplicationActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {


            ToolbarResource = Resource.Layout.Toolbar;
            TabLayoutResource = Resource.Layout.Tabbar;

            base.OnCreate(bundle);
        }
    }
}

