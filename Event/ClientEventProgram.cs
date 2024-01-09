using Event;

class ClientEventProgram
{
    public delegate void Notificate(string email);

    public event Notificate Notified;

    public void NotifyClients(IEnumerable<Client> clients)
    {
        foreach (var client in clients)
        {
            Notified(client.Email);
        }
    }

    private static void Main()
    {
    }
}