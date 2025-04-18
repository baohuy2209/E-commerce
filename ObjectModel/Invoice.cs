using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Invoice
    {
        public string InvoiceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public float TotalAmount { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string OrderId { get; set; }
    }
}
