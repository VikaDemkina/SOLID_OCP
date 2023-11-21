namespace OCP;

public class DeliveryService
{
    private Dictionary<string, IDeliveryMethod> deliveryMethods;

    public DeliveryService()
    {
        deliveryMethods = new Dictionary<string, IDeliveryMethod>
        {
            { "Самовывоз", new PickupDelivery() },
            { "Курьерская доставка", new CourierDelivery() },
            { "Почтовая доставка", new PostalDelivery() }
        };
    }

    public void DeliverOrder(Order order, string deliveryMethod)
    {
        if (deliveryMethods.TryGetValue(deliveryMethod, out IDeliveryMethod method))
        {
            method.Deliver(order);
        }
        else
        {
            Console.WriteLine("Неподдерживаемый метод доставки.");
        }
    }
}