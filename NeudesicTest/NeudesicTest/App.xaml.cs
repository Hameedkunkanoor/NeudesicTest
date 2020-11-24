using MvvmCross.Forms.Core;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeudesicTest
{
    public partial class App : MvxFormsApplication
    {

       public App()
        {

            InitializeComponent();


        }

        protected override void OnStart()
        {
            base.OnStart();
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            base.OnSleep();

            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            base.OnResume();

            // Handle when your app resumes
        }
    }
}
