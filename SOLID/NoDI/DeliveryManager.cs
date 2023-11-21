class DeliveryManager
{
    private DeliveryService deliveryService;

    public DeliveryManager()
    {
        this.deliveryService = new DeliveryService();
    }

    public void ProcessDelivery(string address, string package)
    {
        // логика обработки доставки
        deliveryService.Deliver(address, package);
        Console.WriteLine("ƒоставка обработана");
    }
}