using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Delivery
    {
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }


    }
}
