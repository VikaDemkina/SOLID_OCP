public class Order
{
    public string OrderId { get; set; }
    public string CustomerName { get; set; }
}

class Program
{
    static void Main()
    {
        var order = new Order
        {
            OrderId = "1",
            CustomerName = "Демкина Виктория Алексеевна"
        };

        var deliveryService = new DeliveryService();
        
        deliveryService.DeliverOrder(order, "Самовывоз");
        deliveryService.DeliverOrder(order, "Курьерская доставка");
        deliveryService.DeliverOrder(order, "Почтовая доставка");
        deliveryService.DeliverOrder(order, "Доставка голубем");

        Console.ReadLine();
    }
}