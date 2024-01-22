using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class OfferHistory : BaseDomainModel
    {
        public int? OfferId { get; set; }
        public virtual Offer? Offer { get; set; }
    }
}
