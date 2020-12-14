using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafetyTourism_Group4.Models
{
    public class Tourist
    {
    
        [Key]
        public string emailID { get => emailID; set => emailID = value; }
        public string name { get => name; set => name = value; }
        public string nationality { get => nationality; set => nationality = value; }
        public DateTime birthDate { get => birthDate; set => birthDate = value; }
    }
}
