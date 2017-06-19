using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberPortal.Models.ProfileViewModels
{
    public class WorkHistoryViewModel
    {
        public string MemberId { get; set; }
        public decimal AnnuityCont { get; set; }
        public decimal Hours { get; set; }
        public decimal CheckOff { get; set; }
        public int RemitNo { get; set; }
        public DateTime DateReceived { get; set; }
        public string Employer { get; set; }
        public DateTime WorkMonth { get; set; }
        public decimal PensionCont { get; set; }
        public decimal HealthCont { get; set; }
    }
}
