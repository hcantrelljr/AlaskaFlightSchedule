using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace AlaskaFlightSchedule.Core.Models
{
    public class FlightDetails
    {
        [JsonProperty("operatingFlightNumber")]
        public string OperatingFlightNumber { get; set; }

        [JsonProperty("flightLegs")]
        public IList<FlightLegs> FlightLegs { get; set;}

        public string FlightDeparture => FlightLegs.First().EstimatedDateTimeUTC.Out.ToLocalTime().ToString();
        public string FlightArrival => FlightLegs.First().EstimatedDateTimeUTC.In.ToLocalTime().ToString();
    }
}
