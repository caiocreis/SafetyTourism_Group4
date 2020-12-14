using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
