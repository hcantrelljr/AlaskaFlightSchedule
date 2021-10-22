using Newtonsoft.Json;

namespace AlaskaFlightSchedule.Core.Models
{
    public class FlightLegs
    {
        [JsonProperty("legNumber")]
        public int LegNumber { get; set; }

        [JsonProperty("scheduledDateTimeUTC")]
        public FlightDateTime ScheduledDateTimeUTC { get; set; }

        [JsonProperty("estimatedDateTimeUTC")]
        public FlightDateTime EstimatedDateTimeUTC { get; set; }
    }
}
