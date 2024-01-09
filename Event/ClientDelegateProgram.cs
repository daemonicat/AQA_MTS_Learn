using Event;

class ClientDelegateProgram
{
    public delegate int CalculateDiscount(ClientType clientType);

    public CalculateDiscount CalculateDiscountForClient { get; set; }

    private void CalculateDiscounts(IEnumerable<Client> clients)
    {
        foreach (var client in clients)
        {
            client.Discount = CalculateDiscountForClient(client.Type);
        }
    }
    
    static void Main2()
    {
    }
}
 