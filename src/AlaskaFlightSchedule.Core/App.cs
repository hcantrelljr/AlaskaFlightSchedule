using MvvmCross.IoC;
using MvvmCross.ViewModels;
using AlaskaFlightSchedule.Core.ViewModels.Main;
using MvvmCross;

namespace AlaskaFlightSchedule.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
