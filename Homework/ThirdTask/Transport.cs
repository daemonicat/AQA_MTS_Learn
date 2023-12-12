namespace Homework.ThirdTask;

public abstract class Transport
{
    public string Destination { get; init; }

    public int Number { get; init; }

    public TimeOnly DepartureTime { get; init; }

    public int AmountSeats { get; init; }

    public abstract string? GetTransportType();

    public void TransportInfo()
    {
        Console.WriteLine($"Number: {Number}, Destination: {Destination}, Departure time: {DepartureTime}, Amount of seats: {AmountSeats}");
    }

}