using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafetyTourism.Models
{
    public class Disease
    {
        public int diseaseID { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
    }
}
