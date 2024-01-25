using ConsoleApp.Model;

namespace ConsoleApp.Utility
{
    public class FlightUtility
    {
        public static void DisplayFlight(Flight flight)
        {
            Console.WriteLine($"Flight: {flight.FlightNumber}, departure: {flight.Departure}, arrival: {flight.Destination}, day: {flight.Day}");
        }
    }
}
