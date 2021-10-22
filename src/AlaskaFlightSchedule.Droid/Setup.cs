using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using AlaskaFlightSchedule.Core;
using Serilog;
using Serilog.Extensions.Logging;
using MvvmCross.ViewModels;
using MvvmCross.IoC;
using MvvmCross;
using AlaskaFlightSchedule.Core.Services;
using AlaskaFlightSchedule.Common.Services;

namespace AlaskaFlightSchedule.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override ILoggerProvider CreateLogProvider() => new SerilogLoggerProvider();

        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }

        protected override IMvxApplication CreateApp(IMvxIoCProvider iocProvider)
        {
            IMvxApplication app = base.CreateApp(iocProvider);

            Mvx.IoCProvider.RegisterSingleton<IRestService>(new RestService());

            return app;
        }
    }
}
