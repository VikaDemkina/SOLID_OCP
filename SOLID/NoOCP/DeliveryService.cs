public class DeliveryService
{
    public void DeliverOrder(Order order, string deliveryMethod)
    {
        if (deliveryMethod == "Самовывоз")
        {
            Console.WriteLine("Заказ передан на самовывоз.");
        }
        else if (deliveryMethod == "Курьерская доставка")
        {
            Console.WriteLine("Заказ передан курьеру для доставки.");
        }
        else if (deliveryMethod == "Почтовая доставка")
        {
            Console.WriteLine("Заказ отправлен почтой.");
        }
        else
        {
            Console.WriteLine("Неподдерживаемый метод доставки.");
        }
    }
}