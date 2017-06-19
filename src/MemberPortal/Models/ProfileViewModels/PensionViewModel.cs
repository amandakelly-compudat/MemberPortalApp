using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberPortal.Models.ProfileViewModels
{
    public class PensionViewModel
    {
        public int MemberId { get; set; }
        public decimal PensionCredits { get; set; }
        public decimal VestingCredits { get; set; }
        public decimal BankHours { get; set; }
        public decimal MonthlyAmount { get; set; }
        public string PensionType { get; set; }
        public int Year { get; set; }
        public decimal ContAmount { get; set; }
    }
}
