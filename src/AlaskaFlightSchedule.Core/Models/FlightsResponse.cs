using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace AlaskaFlightSchedule.Core.Models
{
    public class FlightsResponse
    {
        [JsonProperty("flights")]
        public IList<Flight> Flights { get; set; }

        public IList<Flight> FlightsSorted => Flights.OrderBy(x => x.FlightDetails.FlightLegs.First().EstimatedDateTimeUTC.Out.ToLocalTime().ToString()).ToList();
    }
}
