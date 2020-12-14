using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism.Models
{
    public class Destination
    {
        public int destinationID { get; set; }
        public string countryName { get; set; }
        public string cityName { get; set; }
        public int populationNum { get; set; }
        public List<Report> reportList { get; set; }

    }
}
