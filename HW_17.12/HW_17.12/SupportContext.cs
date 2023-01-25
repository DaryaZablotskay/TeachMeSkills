using HW_17._12.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_17._12
{
    public class SupportContext : DbContext
    {
        public DbSet<SupportRequest> SupportRequests { get; set; }
        public DbSet<SupportSpecialist> SupportSpecialists { get; set; }
        public DbSet<Department> Departments { get; set; }

        public SupportContext(DbContextOptions<SupportContext> context) : base(context)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupportRequest>()
                .HasOne(x => x.SupportSpecialist)
                .WithMany(y => y.SupportRequests)
                .HasForeignKey(x => x.SupportSpecialistId);

            modelBuilder.Entity<SupportSpecialist>()
                .HasOne(x => x.Department)
                .WithMany(y => y.SupportSpecialists)
                .HasForeignKey(x => x.DepartmentId);

            modelBuilder.Entity<SupportRequest>()
                .Property(x => x.Topic)
                .HasMaxLength(1000);

            modelBuilder.Entity<SupportRequest>()
                .Property(x => x.Description)
                .HasMaxLength(1000);

            modelBuilder.Entity<SupportRequest>()
                .Property(x => x.Status)
                .HasMaxLength(1000);

            modelBuilder.Entity<Department>()
                .Property(x => x.Name)
                .HasMaxLength(1000);

            modelBuilder.Entity<SupportSpecialist>()
                .Property(x => x.Name)
                .HasMaxLength(1000);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-C122T4K;Database=Support;Trusted_Connection=True;");
        }
    }
}
