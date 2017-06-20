using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MemberPortal.Models.ProfileViewModels
{
    public class ProfileIndexViewModel
    {
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string ProfileImage { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
