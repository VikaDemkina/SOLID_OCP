class Program
{
    static void Main(string[] args)
    {
        DeliveryManager deliveryManager = new DeliveryManager();

        deliveryManager.ProcessDelivery("ул. Образцова 9", "Важный пакет");

        Console.ReadLine();
    }
}