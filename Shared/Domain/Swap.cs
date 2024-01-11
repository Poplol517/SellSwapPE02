using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Swap : BaseDomainModel
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }   
        public int MeetupId { get; set; }
        public Meetup? Meetup { get; set; } 
    }
}
