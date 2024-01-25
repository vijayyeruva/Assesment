namespace ConsoleApp.Model
{
    public class Flight
    {
        public int FlightNumber { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public int Day { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public bool IsFull => Orders.Count >= 20;

        public void ScheduleOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}
