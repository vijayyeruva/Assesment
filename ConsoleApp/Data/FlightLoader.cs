using ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Data
{
    public class FlightLoader
    {
        public List<Flight> LoadFlights()
        {
            return new List<Flight>()
        {
            new Flight { FlightNumber = 1, Departure = "YUL", Destination = "YYZ", Day = 1 },
            new Flight { FlightNumber = 2, Departure = "YUL", Destination = "YYC", Day = 1 },
            new Flight { FlightNumber = 3, Departure = "YUL", Destination = "YVR", Day = 1 },
            new Flight { FlightNumber = 4, Departure = "YUL", Destination = "YYZ", Day = 2 },
            new Flight { FlightNumber = 5, Departure = "YUL", Destination = "YYC", Day = 2 },
            new Flight { FlightNumber = 6, Departure = "YUL", Destination = "YVR", Day = 2 },
        };
        }
    }
}
