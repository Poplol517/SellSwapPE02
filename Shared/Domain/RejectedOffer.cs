using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class RejectedOffer : BaseDomainModel
    {
        public string? AccountId { get; set; }
        public virtual Account? Account { get; set; }
        public int? OfferId { get; set; }
        public virtual Offer? Offer { get; set; }

    }
}
