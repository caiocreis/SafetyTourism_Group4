using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafetyTourism_Group4.Models
{
    public class Report
    {
       
        [Key]
        public int reportID { get => reportID; set => reportID = value; }

        public int destinationID { get => reportID; set => reportID = value; }
        public string creationDate { get => creationDate; set => creationDate = value; }
        public string infectionName { get => infectionName; set => infectionName = value; }
        public int infectedNum { get => infectedNum; set => infectedNum = value; }
        public string omsAdvice { get => omsAdvice; set => omsAdvice = value; }
        public Destination destination { get; set; }
    }
}
