using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class ListingStatus : BaseDomainModel
    {
        [Required]
        public string? Name { get; set; }
    }
}
