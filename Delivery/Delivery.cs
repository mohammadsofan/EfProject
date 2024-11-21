using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DeliveryStatus deliveryStatus { get; set; }

        public override string ToString()
        {
            return $"{{\n   Id : {Id}\n   Customer Name : {CustomerName} \n   Address : {Address} \n   Delivery Status : {deliveryStatus} \n}}";
        }
    }
}
