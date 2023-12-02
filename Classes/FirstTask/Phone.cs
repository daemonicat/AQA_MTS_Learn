namespace Classes.FirstTask;

public class Phone
{
    private readonly string _number;
    private readonly string _model;
    private readonly int _weight;

    // Constructor without parameters
    public Phone()
    {
        _number = "79990129357";
        _model = "DefaultModel";
        _weight = 154;
    }

    // Constructor with number and model parameters
    public Phone(string number, string model)
    {
        _number = number;
        _model = model;
        _weight = 243;
    }

    // Constructor with all parameters
    public Phone(string number, string model, int weight) : this(number, model)
    {
        _weight = weight;
    }

    // receiveCall method with caller name parameter
    public static void ReceiveCall(string name)
    {
        Console.WriteLine($"Звонит {name} ");
    }

    // getNumber method, returns number
    public void GetNumber()
    {
        Console.WriteLine(_number);
    }

    // sendMessage method, takes phone numbers to which the message will be sent as input
    public void SendMessage(IEnumerable<string> recipients)
    {
        Console.WriteLine($"Message \"Hey there, are you okay?\" was sent from the number {_number} to numbers:");
        foreach (var recipient in recipients)
            Console.WriteLine(recipient);
    }

    public void Print()
    {
        Console.WriteLine($"Phone number: {_number}, Model: {_model}, Weight: {_weight}");
    }
}