using ConsoleApp.Business;
using ConsoleApp.Data;
using ConsoleApp.Model;

class Program
{
    static void Main()
    {
        List<Order> orders = ProgramHelpers.ReadOrdersFromFile("orders.json");

        FlightScheduler scheduler = new FlightScheduler();
        var flightLoader = new FlightLoader();
        scheduler.LoadFlightSchedule(flightLoader.LoadFlights());
        scheduler.DisplayFlightSchedule();

        scheduler.ScheduleFlights(orders);
        scheduler.GenerateFlightItineraries(orders);
    }
}
