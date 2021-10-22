using System;
using System.Threading.Tasks;
using AlaskaFlightSchedule.Core.Models;

namespace AlaskaFlightSchedule.Core.Services
{
	public interface IRestService
	{
		Task<FlightsResponse> GetFlights(string origin, string destination, DateTime flightDate);
	}
}
