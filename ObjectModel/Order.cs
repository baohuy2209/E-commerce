using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Order
    {
        public string OrderId { get; set; }
        public int CustomerId { get; set; }
        public string CartId { get; set; }
        public DateTime CreatedDate { get; set; }
        public float TotalAmount { get; set; }
    }
}
