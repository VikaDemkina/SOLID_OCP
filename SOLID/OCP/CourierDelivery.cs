namespace OCP;

public class CourierDelivery : IDeliveryMethod
{
    public void Deliver(Order order)
    {
        Console.WriteLine($"Заказ {order.OrderId} доставлен курьером.");
    }
}