using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Feedback
    {
        public string FeedbackId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime PostedDate { get; set; }
        public string ProductId { get; set; }
    }
}
