using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AlaskaFlightSchedule.Core.Services;
using AlaskaFlightSchedule.Core.Models;
using System.Globalization;

namespace AlaskaFlightSchedule.Common.Services
{
	//https://apis.qa.alaskaair.com/aag/1/guestServices/flights/?fromDate=2021-07-25&toDate=2021-07-25&origin=SEA&destination=LAX&nonStopOnly=false
	//When you are making the API call, you will need to supply a subscription key in the HttpHeader:
	//Name of the key: Ocp-Apim-Subscription-Key
	//Value of the key: 82cc4b621ce64152a1cc7861e3a02f65

	public class RestService : IRestService
	{
		public HttpClient Client { get; private set; }

		public RestService()
		{
            Client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000
            };

            Client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "82cc4b621ce64152a1cc7861e3a02f65");
			Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public async Task<FlightsResponse> GetFlights(string origin, string destination, DateTime flightDate)
		{
			FlightsResponse flightsResponse = null;

			try
			{
				var flightDateStr = flightDate.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
				var url = RestConstants.FlightsRestUrl + "?fromDate=" + flightDateStr + "&toDate=" + flightDateStr + "&origin=" + origin + "&destination=" + destination + "&nonStopOnly=false";
				HttpResponseMessage response = await Client.GetAsync(url);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					flightsResponse = JsonConvert.DeserializeObject<FlightsResponse>(content);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(@"ERROR {0}", ex.Message);
			}

			return flightsResponse;
		}
	}
}
