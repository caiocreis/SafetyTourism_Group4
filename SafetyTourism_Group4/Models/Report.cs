using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism_Group4.Models
{
    public class Report
    {
        private int reportID;
        private string creationDate;
        private string infectionName;
        private int infectedNum;
        private string omsAdvice;

        public Report(int reportID, string creationDate, string infectionName, int infectedNum, string omsAdvice)
        {
            this.reportID = reportID;
            this.creationDate = creationDate;
            this.infectionName = infectionName;
            this.infectedNum = infectedNum;
            this.omsAdvice = omsAdvice;            
        }

        public int ReportID { get => reportID; set => reportID = value; }
        public string CreationDate { get => creationDate; set => creationDate = value; }
        public string InfectionName { get => infectionName; set => infectionName = value; }
        public int InfectedNum { get => infectedNum; set => infectedNum = value; }
        public string OmsAdvice { get => omsAdvice; set => omsAdvice = value; }
        public Destination destination { get; set; }
    }
}
