using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Supplier { get; set; }
        public float WarrantyPeriod { get; set; }
        public string Category { get; set; }
    }
}
