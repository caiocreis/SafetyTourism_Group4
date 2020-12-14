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

        [Display(Name = "Country Name")]
        public string countryName { get; set; }

        [Display(Name = "City Name")]
        public string cityName { get; set; }

        [Display(Name = "Population Number")]
        public int populationNum { get; set; }
        public List<Report> reportList { get; set; }

    }
}
