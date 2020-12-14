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
            new Employee{nifID=123123123,name="Carson",address="Frankfort Avenue, 8, Dublin",email="carson@carson.pt",phoneNumber=083522565}
            };
            foreach (Employee e in employees) {
                context.Employees.Add(e);
            }
            context.SaveChanges();

            var destinations = new Destination[]
            {
            new Destination{destinationID=1050,countryName="Australia",cityName="Sydney"},
            new Destination{destinationID=4022,countryName="Spain",cityName="Madrid"},
            new Destination{destinationID=4041,countryName="Portugal",cityName="lisbon"},
            new Destination{destinationID=1045,countryName="India",cityName="New Dehli"},
            new Destination{destinationID=3141,countryName="Italy",cityName="Rome"},
            new Destination{destinationID=2021,countryName="Japan",cityName="Tokyo"},
            new Destination{destinationID=2042,countryName="Angola",cityName="Luanda"}
            };
            foreach (Destination d in destinations) {
                context.Destinations.Add(d);
            }
            context.SaveChanges();

            var reports = new Report[]
            {
            new Report{reportID=1,creationDate="20/05/2005",infectionName="Covids",infectedNum=1,omsAdvice="Be careful",destinationID=1050},
            };
            foreach (Report r in reports) {
                context.Reports.Add(r);
            }
            context.SaveChanges();
        }
    }
}


