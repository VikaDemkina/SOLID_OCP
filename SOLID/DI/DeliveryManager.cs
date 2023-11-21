class DeliveryManager
{
	private IDeliveryService deliveryService;

	public DeliveryManager(IDeliveryService deliveryService)
	{
		this.deliveryService = deliveryService;
	}

	public void ProcessDelivery(string address, string package)
	{
		// логика обработки доставки
		deliveryService.Deliver(address, package);
		Console.WriteLine("ƒоставка обработана");
	}
}
