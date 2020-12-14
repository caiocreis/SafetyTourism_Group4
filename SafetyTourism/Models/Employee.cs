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
        public long nifID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public long phoneNumber { get; set; }
    }
}
