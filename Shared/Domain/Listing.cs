using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SellSwap.Shared.Domain
{
    public class Listing : BaseDomainModel
    {
        public string? Lister { get; set; }
        public string? ListerId { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 2, ErrorMessage ="Listing Name not meeting length requirement (Minimum Name length 2)")]
        public string? Name { get; set; }
        [Required]
        public int? ConditionTypeId { get; set; }
        public virtual ConditionType?  ConditionType { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public string? AccountId { get; set; }
        public virtual Account? Account { get; set; }
        public int? ListingStatusId { get; set; }
        public virtual ListingStatus? ListingStatus { get; set; }
        [Required]
        public int? ListingTypeId { get; set; }
        public virtual ListingType? ListingType { get; set; }
        //public virtual List<Favourite>? Favourites { get; set; }
        public string? Image { get; set; }



    }
}
