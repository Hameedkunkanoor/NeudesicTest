using MvvmCross.ViewModels;
using System;
using MvvmCross.IoC;
using NeudesicTest.ViewModels;

namespace NeudesicTest
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

               RegisterAppStart<HomeViewModel>();
           
        }
    }
}
