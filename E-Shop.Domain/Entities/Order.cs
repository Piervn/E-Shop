using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string ProductId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string PaymentMethod { get; set; }
        public string DeliveryMethod { get; set; }
        public string DeliveryAdress { get; set; }
        public string Status { get; set; }
        public string TotalPrice { get; set; }
    }
}
