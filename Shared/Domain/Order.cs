using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserID { get; set; }
        public virtual User? User { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment? Payment { get; set;}
    }
}
