using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism.Models
{
    public class Outbreak
    {
        public int outbreakID { get; set; }
        public int diseaseID { get; set; }
        public DateTime startDate { get; set; }
    }
}
