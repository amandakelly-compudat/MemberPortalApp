using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MemberPortal.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        [DisplayFormat(DataFormatString = "{0:###-##-####}")]
        public int Ssn { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:###-###-####}")]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Local { get; set; }
        public string Employer { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime Retired { get; set; }
        public string Medical { get; set; }
        public string ProfileImage { get; set; }

        //public virtual ICollection<Pension> Pensions { get; set; }
    }

}
