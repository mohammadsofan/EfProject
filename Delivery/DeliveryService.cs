using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class DeliveryService
    {
        private readonly Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);
            }
            catch(AccidentException e)
            {
                Console.WriteLine(e.Location +" "+ e.Message);
                delivery.deliveryStatus = DeliveryStatus.UNKNOWN;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                delivery.deliveryStatus = DeliveryStatus.UNKNOWN;
            }
        }
        private void Process(Delivery delivery)
        {
            FakeIt("processing");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Error with process operation");
            }
            delivery.deliveryStatus = DeliveryStatus.PROCESSED;
        }
        private void Ship(Delivery delivery)
        {
            FakeIt("shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Error with Ship operation");
            }
            delivery.deliveryStatus = DeliveryStatus.SHIPPED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("On Its Way");
            if (random.Next(1, 5) == 1)
            {
                throw new AccidentException("howara","ACCIDENT!");
            }
            delivery.deliveryStatus = DeliveryStatus.INTRANSIT;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("delivering");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Error with Deliver operation");
            }
            delivery.deliveryStatus = DeliveryStatus.DELIVERED;

        }
        public void FakeIt(string title)
        {

            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".\n");
        }
    }
}
