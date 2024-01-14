using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class ListingStatus : BaseDomainModel
    {
        
        public string? Name { get; set; }
        public List<Listing>? Listing { get; set; }

    }
}
