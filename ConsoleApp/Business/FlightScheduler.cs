using ConsoleApp.Model;
using ConsoleApp.Utility;

namespace ConsoleApp.Business
{
    public class FlightScheduler
    {
        private List<Flight> flights = new List<Flight>();

        public void LoadFlightSchedule(List<Flight> newFlights)
        {
            flights.AddRange(newFlights);
        }

        public void ScheduleFlights(List<Order> orders)
        {
            foreach (var order in orders)
            {
                ScheduleOrder(order);
            }
        }

        private Flight GetNextAvailableFlight(string destination, bool alternativeFlight = false)
        {
            return flights
                .Where(f => f.Destination == destination && (!alternativeFlight || (alternativeFlight && f.Day != 1)))
                .FirstOrDefault(f => !f.IsFull);
        }

        private void ScheduleOrder(Order order)
        {
            var availableFlight = GetNextAvailableFlight(order.Destination);
            if (availableFlight != null)
            {
                availableFlight.ScheduleOrder(order);
            }
            else
            {
                Console.WriteLine($"order: {GenerateUnscheduledOrderId(order.OrderId)}, flightNumber: not scheduled");
            }
        }

        private string GenerateUnscheduledOrderId(string orderId)
        {
            return $"order-{orderId}";
        }

        public void DisplayFlightSchedule()
        {
            foreach (var flight in flights)
            {
                FlightUtility.DisplayFlight(flight);
            }
        }

        public void GenerateFlightItineraries(List<Order> orders)
        {
            foreach (var flight in flights)
            {
                var scheduledOrders = flight.Orders;
                if (scheduledOrders.Any())
                {
                    foreach (var order in scheduledOrders)
                    {
                        Console.WriteLine($"order: {order.OrderId}, flightNumber: {flight.FlightNumber}, departure: {flight.Departure}, arrival: {flight.Destination}, day: {flight.Day}");
                    }
                }
                else
                {
                    Console.WriteLine($"order: {GenerateUnscheduledOrderId(flight.FlightNumber.ToString())}, flightNumber: not scheduled");
                }
            }
        }
    }
}
