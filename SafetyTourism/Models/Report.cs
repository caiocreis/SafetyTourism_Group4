using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SafetyTourism.Models
{
    public class Report
    {
        public int reportID { get; set; }
        public int diseaseID { get; set; }
        public int destinationID { get; set; }
        public int recomWhoID { get; set; }
        public int infectedPeople { get; set; }
    }
}
