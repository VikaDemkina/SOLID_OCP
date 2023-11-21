interface IDeliveryService
{
    void Deliver(string address, string package);
}

class DeliveryService : IDeliveryService
{
    public void Deliver(string address, string package)
    {
        // логика доставки по указанному адресу
        Console.WriteLine($"Пакет доставлен по адресу: {address}");
    }
}