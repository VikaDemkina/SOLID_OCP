class Program
{
    static void Main(string[] args)
    {
        IDeliveryService deliveryService = new DeliveryService();
        DeliveryManager deliveryManager = new DeliveryManager(deliveryService);

        deliveryManager.ProcessDelivery("ул. Образцова 9", "Важный пакет");

        Console.ReadLine();
    }
}