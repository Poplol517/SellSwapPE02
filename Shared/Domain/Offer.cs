using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Offer : BaseDomainModel
    { 
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
        public int? ListingId { get; set; }
        public virtual Listing? Listing { get; set; }
        public int? Price { get; set; }
    }
}
