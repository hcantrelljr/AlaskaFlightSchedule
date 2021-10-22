using System;
using System.Windows.Input;
using AlaskaFlightSchedule.Core.Models;
using AlaskaFlightSchedule.Core.Services;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace AlaskaFlightSchedule.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; } = DateTime.Now;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand SearchCommand => new MvxAsyncCommand(async () =>
                {
                    IRestService restService = Mvx.IoCProvider.Resolve<IRestService>();
                    FlightsResponse flightResponse = await restService.GetFlights(Origin, Destination, FlightDate);

                    await _navigationService.Navigate<FlightsViewModel, FlightsResponse>(flightResponse);
                });
    }
}
