using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism_Group4.Models
{
    public class Destination
    {
        private int destinationID;
        private string contryName;
        private string cityName;
        private List<Report> reportList;

        public Destination(int destinationID, string contryName, string cityName, List<Report> reportList)
        {
            this.destinationID = destinationID;
            this.contryName = contryName;
            this.cityName = cityName;
            this.reportList = reportList;
        }

        public int DestinationID { get => destinationID; set => destinationID = value; }
        public string ContryName { get => contryName; set => contryName = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public List<Report> ReportList { get => reportList; set => reportList = value; }
    }
}
