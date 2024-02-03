using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Conversation : BaseDomainModel
    {
        public string? User1 { get; set; }
        public string? User2 { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? ListingId { get; set; }
        public virtual Listing? Listing { get; set; }
    }
}
