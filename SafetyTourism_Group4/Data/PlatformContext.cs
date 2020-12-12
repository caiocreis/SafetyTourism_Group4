using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafetyTourism_Group4.Models;
using Microsoft.EntityFrameworkCore;

namespace SafetyTourism_Group4.Data
{
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions<PlatformContext> options) : base(options) { }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>().ToTable("Destination");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Tourist>().ToTable("Tourist");
            modelBuilder.Entity<Report>().ToTable("Report");
        }
    }
}
