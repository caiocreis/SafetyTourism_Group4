using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafetyTourism.Models
{
    public class Employee
    {
        [Key]
        public long ID { get; set; }

        [Display(Name = "Nif")]
        public long nif { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Address")]
        public string address { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        public long phoneNumber { get; set; }
    }
}
