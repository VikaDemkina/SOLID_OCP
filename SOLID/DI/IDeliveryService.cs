interface IDeliveryService
{
    void Deliver(string address, string package);
}

class DeliveryService : IDeliveryService
{
    public void Deliver(string address, string package)
    {
        // ������ �������� �� ���������� ������
        Console.WriteLine($"����� ��������� �� ������: {address}");
    }
}