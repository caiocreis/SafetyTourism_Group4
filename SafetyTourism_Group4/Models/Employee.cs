using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism_Group4.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        private long nifID;
        private string name;
        private string address;
        private string email;
        private long phoneNumber;

        public long NifID { get => nifID; set => nifID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
