using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        
        public string? Name { get; set; }
        public string? Condition { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; } 
        public int OrderId { get; set; }
        public virtual Order? Order {  get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
