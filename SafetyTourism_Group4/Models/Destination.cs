using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafetyTourism_Group4.Models
{
    public class Destination
    {
        
        [Key]
        public int destinationID { get => destinationID; set => destinationID = value; }
        public string countryName { get => countryName; set => countryName = value; }
        public string cityName { get => cityName; set => cityName = value; }
        public List<Report> reportList { get => reportList; set => reportList = value; }
    }
}
