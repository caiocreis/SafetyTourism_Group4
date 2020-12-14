using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafetyTourism.Models;

namespace SafetyTourism.Data
{
    public class DbInitializer
    {
            public static void Initialize(PlatformContext context)
            {
                context.Database.EnsureCreated();

                // Look for any destinations.
                if (context.Destinations.Any())
                {
                    return;   // DB has been seeded
                }

                var employees = new Employee[]
                {
                    new Employee{nifID=123123123, name="Carson", address="Frankfort Avenue, 8, Dublin", email="carson@carson.pt", phoneNumber=083522565},
                    new Employee{nifID=333333333, name="Allison", address="Street, 9, India", email="allison@thisisanemail.com", phoneNumber=323232322}
                };
                foreach (Employee e in employees)
                {
                    context.Employees.Add(e);
                }
                context.SaveChanges();

                var destinations = new Destination[]
                {
                    new Destination{destinationID=1050,countryName="Australia",cityName="Sydney", populationNum=100},
                    new Destination{destinationID=4022,countryName="Spain",cityName="Madrid", populationNum=1030},
                    new Destination{destinationID=4041,countryName="Portugal",cityName="lisbon", populationNum=110},
                    new Destination{destinationID=1045,countryName="India",cityName="New Dehli", populationNum=120},
                    new Destination{destinationID=3141,countryName="Italy",cityName="Rome", populationNum=150},
                    new Destination{destinationID=2021,countryName="Japan",cityName="Tokyo", populationNum=200},
                    new Destination{destinationID=2042,countryName="Angola",cityName="Luanda", populationNum=300}
                };
                foreach (Destination d in destinations)
                {
                    context.Destinations.Add(d);
                }
                context.SaveChanges();

                var diseases = new Disease[]
                {
                    new Disease{diseaseID=1, name="SARS-Cov2", description="Coronavirus disease 2019 (COVID-2019) is caused by a novel coronavirus known as Severe Acute Respiratory Syndrome Coronavirus 2 (SARS-CoV-2) and was identified as a pandemic by the World Health Organization (WHO) on March 11, 2020"},
                    new Disease{diseaseID=2, name="Malaria", description="Malaria is caused by Plasmodium parasites, transmitted to humans through the bites of infected Anopheles mosquitoes."}
                };
                foreach (Disease d in diseases)
                {
                    context.Diseases.Add(d);
                }
                context.SaveChanges();

                var reports = new Report[]
                {
                    new Report{reportID=1, diseaseID=1, destinationID=1, recomWhoID=1,infectedPeople=40 },
                    new Report{reportID=2, diseaseID=2, destinationID=2, recomWhoID=2,infectedPeople=70 }
                };
                foreach (Report r in reports)
                {
                    context.Reports.Add(r);
                }
                context.SaveChanges();

                var outbreaks = new Outbreak[]
                {
                    new Outbreak{outbreakID=1, diseaseID=1, startDate=DateTime.Parse("2005-09-01")},
                    new Outbreak{outbreakID=2, diseaseID=2, startDate=DateTime.Parse("2009-10-01")}
                };
                foreach (Outbreak o in outbreaks)
            {
                context.Outbreaks.Add(o);
            }
                context.SaveChanges();

            var recommendations = new RecomWHO[]
               {
                   new RecomWHO{recomID=1, description="Maintain at least a 1-metre distance between yourself and others to reduce your risk of infection when they cough, sneeze or speak. Maintain an even greater distance between yourself and others when indoors. The further away, the better."},
                   new RecomWHO{recomID=2, description="Make wearing a mask a normal part of being around other people. The appropriate use, storage and cleaning or disposal are essential to make masks as effective as possible."}
               };
                foreach (RecomWHO r in recommendations)
            {
                context.RecomendationsWHO.Add(r);
            }
            context.SaveChanges();
        }
        }
    }