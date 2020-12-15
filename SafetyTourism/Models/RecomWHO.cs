using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafetyTourism.Models
{
    public class RecomWHO
    {
        [Key]
        public int ID { get; set; }

        public string description { get; set; }
    }
}
