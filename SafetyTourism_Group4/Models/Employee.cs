using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafetyTourism_Group4.Models
{
    public class Employee
    {

        [Key]
        public int nifID { get => nifID; set => nifID = value; }
        public string name { get => name; set => name = value; }
        public string address { get => address; set => address = value; }
        public string email { get => email; set => email = value; }
        public long phoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
