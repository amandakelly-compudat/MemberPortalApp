using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberPortal.Models
{
    public class Pension
    {
        public int MemberId { get; set; }
        public DateTime RetirementDate { get; set; }
        public string PensionType { get; set; }
        public bool SpouseOption { get; set; }
        public bool JS50 { get; set; }
        public bool JS75 { get; set; }

    }
}
