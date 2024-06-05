using FlightRestApi.Models;

namespace FlightRestApi.Helpers
{
    public static class AirportHelper
    {
        public static List<Airport> GetAirports()
        {
            return new List<Airport>
            {
                new Airport { Code = "JFK", Name = "John F. Kennedy International Airport", City = "New York", Country = "USA" },
                new Airport { Code = "LHR", Name = "Heathrow Airport", City = "London", Country = "UK" },
                new Airport { Code = "CDG", Name = "Charles de Gaulle Airport", City = "Paris", Country = "France" },
                new Airport { Code = "HND", Name = "Haneda Airport", City = "Tokyo", Country = "Japan" },
            };
        }
    }
}
