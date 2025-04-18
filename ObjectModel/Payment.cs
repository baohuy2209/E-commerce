using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Payment
    {
        public string PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
        public string InvoiceId { get; set; }
    }
}
