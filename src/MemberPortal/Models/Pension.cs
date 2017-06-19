using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberPortal.Models
{
    public class Pension
    {
        [Key]
        public int RemitID { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime RetirementDate { get; set; }
        public string PensionType { get; set; }
        public bool SpouseOption { get; set; }
        public bool JS50 { get; set; }
        public bool JS75 { get; set; }
        public int MemberID { get; set; }

        public virtual Member Member { get; set; }
    }
}