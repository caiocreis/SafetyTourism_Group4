using SafetyTourism_Group4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace SafetyTourism_Group4.Data {
    public static class DbInitializer {
        public static void Initialize(PlatformContext context) {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employees.Any()) {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
            new Employee{NifID=123123123,Name="Carson",Address="Frankfort Avenue, 8, Dublin",Email="carson@carson.pt",PhoneNumber=083522565}
            };
            foreach (Employee e in employees) {
                context.Employees.Add(e);
            }
            context.SaveChanges();

            var destinations = new Destination[]
            {
            new Destination{DestinationID=1050,CountryName="Australia",CityName="Sydney"},
            new Destination{DestinationID=4022,CountryName="Spain",CityName="Madrid"},
            new Destination{DestinationID=4041,CountryName="Portugal",CityName="lisbon"},
            new Destination{DestinationID=1045,CountryName="India",CityName="New Dehli"},
            new Destination{DestinationID=3141,CountryName="Italy",CityName="Rome"},
            new Destination{DestinationID=2021,CountryName="Japan",CityName="Tokyo"},
            new Destination{DestinationID=2042,CountryName="Angola",CityName="Luanda"}
            };
            foreach (Destination d in destinations) {
                context.Destinations.Add(d);
            }
            context.SaveChanges();

            var reports = new Report[]
            {
            new Report{ReportID=1,CreationDate="20/05/2005",InfectionName="Covids",InfectedNum=1,OmsAdvice="Be careful",DestinationID=1050},
            };
            foreach (Report r in reports) {
                context.Reports.Add(r);
            }
            context.SaveChanges();
        }
    }
}


