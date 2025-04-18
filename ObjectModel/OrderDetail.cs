using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class OrderDetail
    {
        public string OrderDetailId { get; set; }
        public string CartItem { get; set; }
        public string OrderId { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float SubTotal { get; set; }
    }
}
