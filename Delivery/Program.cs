namespace Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delivery d = new Delivery()
            {
                Id = 22,
                CustomerName = "ali",
                Address = "nablus"
            };
            Console.WriteLine(d.ToString());
            DeliveryService deliveryService = new();
            deliveryService.Start(d);
            Console.WriteLine(d);
        }
    }
}
