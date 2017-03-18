using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public  short SignUpFree { get; set; }
        public byte DurationTime { get; set; }
        public byte DiscountRate { get; set; }
    }
}