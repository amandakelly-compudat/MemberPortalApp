using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberPortal.Models.ProfileViewModels
{
    public class DependentViewModel
    {
        public int DependentID { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public string Relationship { get; set; }
        public string MaritalStatus { get; set; }
        public decimal BeneficiaryAmt { get; set; }
        public string Status { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime RequestDate { get; set; }
    }
}
