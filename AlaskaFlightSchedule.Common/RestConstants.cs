
namespace AlaskaFlightSchedule.Common
{
	public static class RestConstants
	{
		private static readonly string BaseRestUrl = "https://apis.qa.alaskaair.com/";
		private static readonly string GuestServicesRestUrl = BaseRestUrl + "aag/1/guestServices/";

		public static string FlightsRestUrl = GuestServicesRestUrl + "flights/";
	}
}
