namespace OCP;

public class PostalDelivery : IDeliveryMethod
{
    public void Deliver(Order order)
    {
        Console.WriteLine($"Заказ {order.OrderId} отправлен почтой.");
    }
}