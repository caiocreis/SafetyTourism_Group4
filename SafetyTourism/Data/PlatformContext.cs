using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafetyTourism.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.EntityFrameworkCore;

namespace SafetyTourism.Data
{
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions<PlatformContext> options) : base(options) { 
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Outbreak> Outbreaks { get; set; }
        public DbSet<RecomWHO> RecomendationsWHO{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Disease>().ToTable("Disease");
            modelBuilder.Entity<Report>().ToTable("Report");
            modelBuilder.Entity<Destination>().ToTable("Destination");
            modelBuilder.Entity<Outbreak>().ToTable("Outbreak");
            modelBuilder.Entity<RecomWHO>().ToTable("RecomendationWHO");
        }
    }
}
