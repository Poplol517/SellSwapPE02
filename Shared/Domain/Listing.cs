using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Listing : BaseDomainModel
    {
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public int? ConditionTypeId { get; set; }
        public virtual ConditionType?  ConditionType { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; } 
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int? AccountId { get; set; }
        public virtual Account? Account { get; set; }
        public int? ListingStatusId { get; set; }
        public virtual ListingStatus? ListingStatus { get; set; }
        public int? ListingTypeId { get; set; }
        public virtual ListingType? ListingType { get; set; }
        public virtual List<Favourite>? Favourites { get; set; }
    }
}
