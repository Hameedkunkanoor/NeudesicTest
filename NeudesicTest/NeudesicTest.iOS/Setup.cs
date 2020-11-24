using System;
using MvvmCross.Forms.Platforms.Ios.Core;

namespace NeudesicTest.iOS
{
    public class Setup : MvxFormsIosSetup<CoreApp, App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

        }


    }
}