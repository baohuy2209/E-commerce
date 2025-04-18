using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Cart
    {
        public string CartId { get; set; }
        public DateTime LastUpdated { get; set; }
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
    }
}
