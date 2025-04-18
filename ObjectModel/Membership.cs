using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Membership
    {
        public string MembershipId { get; set; }
        public int CustomerId { get; set; }
        public int Rank { get; set; }
        public float Point { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
