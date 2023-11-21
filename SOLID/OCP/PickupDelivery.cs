namespace OCP;

public class PickupDelivery : IDeliveryMethod
{
    public void Deliver(Order order)
    {
        Console.WriteLine($"Заказ {order.OrderId} готов для самовывоза.");
    }
}