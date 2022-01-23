using Ordering.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Entities
{
    public class Customer : EntityBase
    {
        public int AdressId { get; set; }

        public string Name{ get; set; }
    }
}
