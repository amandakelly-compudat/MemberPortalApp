using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberPortal.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public int Ssn { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Local { get; set; }
        public string Employer { get; set; }
        public DateTime Retired { get; set; }
        public string Medical { get; set; }
        public string ProfileImage { get; set; }

        //public virtual ICollection<Pension> Pensions { get; set; }
    }

}
