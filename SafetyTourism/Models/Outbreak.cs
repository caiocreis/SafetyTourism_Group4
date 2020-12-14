using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafetyTourism.Models
{
    public class Outbreak
    {
        public int outbreakID { get; set; }
        public int diseaseID { get; set; }
        [Display(Name = "Date of Outbreak")]
        public DateTime startDate { get; set; }
    }
}
