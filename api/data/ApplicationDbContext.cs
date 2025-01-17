using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace api.data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) :base(dbContextOptions)

        {
            
        }
        public DbSet<College> College {get;set;}
        public DbSet<Semester> semester {get;set;}
        public DbSet<Subject>  subject {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           builder.Entity<User>()
            .HasMany(u => u.College)
            .WithMany(c => c.Users)
            .UsingEntity(j => j.ToTable("UserColleges"));

            // builder.Entity<College>()
            // .HasMany(u =>u.Semesters)
            // .WithMany(c =>c.Colleges)
            // .UsingEntity(j =>j.ToTable("CollageSemesterSubject"));

            // builder.Entity<College>()
            // .HasMany(u =>u.Subjects)
            // .WithMany(c =>c.Colleges)
            // .UsingEntity(j =>j.ToTable("CollageSemesterSubject"));



            List<IdentityRole> roles = new List<IdentityRole>{
                new IdentityRole{
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole{
                    Name = "CollegeAdmin", 
                    NormalizedName = "COLLEGEADMIN"
                },
                    new IdentityRole{
                    Name = "Lecturer",
                    NormalizedName = "LECTURER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
} 