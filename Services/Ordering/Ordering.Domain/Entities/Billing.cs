using Ordering.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Entities
{
    public class Billing : EntityBase
    {
        public decimal ItemPrice { get; set; }
       
        public decimal TotalCost { get; set;}
    }
}
