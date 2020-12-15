using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafetyTourism.Models
{
    public class Report
    {
        [Key]
        public long ID { get; set; }

        [ForeignKey("Destination")]
        public long destinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
