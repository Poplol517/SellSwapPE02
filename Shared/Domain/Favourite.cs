using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Favourite : BaseDomainModel
    {
        public int ListingId { get; set; }
        public virtual Listing? Listing { get; set; }
        public int? AccountId { get; set; }
        public virtual Account? Account{ get; set; }
    }
}
