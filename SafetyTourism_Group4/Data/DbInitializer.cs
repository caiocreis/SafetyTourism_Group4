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
            new Report{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Report{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Report{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Report{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Report{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Report{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Report{StudentID=3,CourseID=1050},
            new Report{StudentID=4,CourseID=1050},
            new Report{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Report{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Report{StudentID=6,CourseID=1045},
            new Report{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments) {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}