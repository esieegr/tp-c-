using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_6_C_.Models;

namespace TP_6_C_
{
    class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public SchoolContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dbPath = Path.GetFullPath("C:\\Users\\Gianni\\source\\repos\\TP 6 C#\\school.db");
                optionsBuilder.UseSqlite($"Data Source={dbPath}");

            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Student>().ToTable("Students");

            // Config légère (facultatif)
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.FirstName).IsRequired();
                entity.Property(s => s.LastName).IsRequired();
                entity.Property(s => s.Age);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Title).IsRequired();
                entity.Property(s => s.Credits).IsRequired();
            });
        }
    }
}
