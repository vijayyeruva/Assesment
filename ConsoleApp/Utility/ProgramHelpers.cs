using ConsoleApp.Model;
using Newtonsoft.Json;

public static class ProgramHelpers
{

    public static List<Order> ReadOrdersFromFile(string filePath)
    {
        using (StreamReader file = File.OpenText(filePath))
        {
            JsonSerializer serializer = new JsonSerializer();
            Dictionary<string, Order> ordersDict = (Dictionary<string, Order>)serializer.Deserialize(file, typeof(Dictionary<string, Order>));

            List<Order> ordersList = ordersDict
                .Select(kv => { kv.Value.OrderId = kv.Key; return kv.Value; })
                .ToList();

            return ordersList;
        }
    }
}