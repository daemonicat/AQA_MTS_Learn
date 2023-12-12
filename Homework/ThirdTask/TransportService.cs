namespace Homework.ThirdTask;

public class TransportService
{
    public static void PrintTransportType(Transport transport)
    {
        var transportType = transport.GetTransportType();
        Console.WriteLine($"[{transport.GetType().Name}] Transport type - {transportType}");
    }

    public static Transport[] SortBySeats(Transport[] transport)
    {
        for (var i = 0; i < transport.Length; i++)
        {
            for (var j = 0; j < transport.Length - i - 1; j++)
            {
                if (transport[j].AmountSeats > transport[j + 1].AmountSeats)
                {
                    (transport[j], transport[j + 1]) = (transport[j + 1], transport[j]);
                }
            }
        }

        return transport;
    }
}