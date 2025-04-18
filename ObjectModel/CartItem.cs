using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class CartItem
    {
        public string CartItemId { get; set; }
        public string ProductId { get; set; }
        public string CartId { get; set; }
        public int CustomerId { get; set; }
    }
}
