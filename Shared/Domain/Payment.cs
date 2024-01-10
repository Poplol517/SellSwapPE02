﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class Payment
    {
        public int Id { get; set; } 
        public int PaymentTypeId { get; set; }
        public virtual PaymentType? PaymentType { get; set; }
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
