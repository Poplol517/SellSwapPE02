using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class ProductStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public List<Product>? Product { get; set; }

    }
}
