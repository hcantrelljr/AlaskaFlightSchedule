using System;
using Newtonsoft.Json;

namespace AlaskaFlightSchedule.Core.Models
{
    public class FlightDateTime
    {
        [JsonProperty("out")]
        public DateTime Out { get; set;}

        [JsonProperty("in")]
        public DateTime In { get; set; }
    }
}
