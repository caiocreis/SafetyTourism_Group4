using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyTourism_Group4.Models
{
    public class Employee
    {
        private long nifID;
        private string name;
        private string address;
        private string email;
        private long phoneNumber;

        public Employee(long nifID, string name, string address, string email, long phoneNumber)
        {
            this.nifID = nifID;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public long NifID { get => nifID; set => nifID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
