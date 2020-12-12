using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism_Group4.Models
{
    public class Tourist
    {
        private string emailID;
        private string name;
        private string nationality;
        private DateTime birthDate;

        public string EmailID { get => emailID; set => emailID = value; }
        public string Name { get => name; set => name = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
    }
}
