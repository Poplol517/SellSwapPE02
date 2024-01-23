using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Account : BaseDomainModel
    {
        
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public int Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public virtual List<Listing>? Listing { get; set; }
        public virtual List<Offer>? Offer { get; set; }
        public virtual List<Favourite>? Favourites { get; set; }
    }
}
