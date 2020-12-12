using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism_Group4.Models
{
    public class Destination
    {
        private int destinationID;
        private string countryName;
        private string cityName;
        private List<Report> reportList;

        public int DestinationID { get => destinationID; set => destinationID = value; }
        public string CountryName { get => countryName; set => countryName = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public List<Report> ReportList { get => reportList; set => reportList = value; }
    }
}
