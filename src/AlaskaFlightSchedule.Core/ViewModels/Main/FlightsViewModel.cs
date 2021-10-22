using System.Collections.Generic;
using System.Threading.Tasks;
using AlaskaFlightSchedule.Core.Models;

namespace AlaskaFlightSchedule.Core.ViewModels.Main
{
    public class FlightsViewModel : BaseViewModel<FlightsResponse>
    {
        private FlightsResponse _flightsResponse;

        public IList<Flight> Items => _flightsResponse.FlightsSorted;

        public override void Prepare()
        {
            // first callback. Initialize parameter-agnostic stuff here
        }

        public override void Prepare(FlightsResponse flightsResponse)
        {
            // receive and store the parameter here
            _flightsResponse = flightsResponse;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            // do the heavy work here
        }
    }
}
