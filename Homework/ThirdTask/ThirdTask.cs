namespace Homework.ThirdTask;

public static class ThirdTask
{
    public static void Main()
    {
        var transportArray = new Transport[]
        {
            new Bus()
                { AmountSeats = 40, DepartureTime = new TimeOnly(07, 00), Destination = "Dam", Number = 115 },
            new Trolleybus()
                { AmountSeats = 38, DepartureTime = new TimeOnly(09, 43), Destination = "Hospital N12", Number = 2 },
            new Tramcar()
            {
                AmountSeats = 42, DepartureTime = new TimeOnly(07, 49), Destination = "Some destination point idk",
                Number = 45
            }
        };

        Console.WriteLine("Types:");
        foreach (var transport in transportArray)
        {
            TransportService.PrintTransportType(transport);
        }

        Console.WriteLine("Info:");

        foreach (var transport in transportArray)
        {
            transport.TransportInfo();
        }

        transportArray = TransportService.SortBySeats(transportArray);

        var availableTransport = new Transport[transportArray.Length];
        var availableTransportIndex = 0;

        Console.WriteLine("Enter departure time:");
        var inputTime = Console.ReadLine();

        TimeOnly? departureTime = new TimeOnly(int.Parse(inputTime!.Split(':')[0]),
            int.Parse(inputTime.Split(':')[1]));

        Console.WriteLine("Enter destination:");
        var destination = Console.ReadLine();
        var transportFound = false;

        foreach (var transport in transportArray)
        {
            if (destination != transport.Destination || transport.DepartureTime <= departureTime)
            {
                continue;
            }

            availableTransport[availableTransportIndex] = transport;
            availableTransportIndex++;
            transportFound = true;
        }

        if (transportFound)
        {
            for (var i = 0; i < availableTransportIndex; i++)
            {
                availableTransport[i].TransportInfo();
            }
        }
        else
        {
            Console.WriteLine("No transport found");
        }
    }
}