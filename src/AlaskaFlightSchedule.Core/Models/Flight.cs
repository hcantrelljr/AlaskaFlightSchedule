using Newtonsoft.Json;

namespace AlaskaFlightSchedule.Core.Models
{
    public class Flight
    {
        [JsonProperty("flightDetails")]
        public FlightDetails FlightDetails { get; set; }
    }
}
