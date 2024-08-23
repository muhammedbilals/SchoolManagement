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
        public DbSet<CollageSubjects> CollageSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CollageSubjects> (x => x.HasKey(p=> new {p.CollageId, p.SemesterId , p.SubjectId}));

            builder.Entity<CollageSubjects> ()
            .HasOne(u => u.Collage)
            .WithMany(u => u.CollageSubjects)
            .HasForeignKey(p => p.CollageId);

             builder.Entity<CollageSubjects> ()
            .HasOne(u => u.Semester)
            .WithMany(u => u.CollageSubjects)
            .HasForeignKey(p => p.SemesterId);

             builder.Entity<CollageSubjects> ()
            .HasOne(u => u.Subject)
            .WithMany(u => u.CollageSubjects)
            .HasForeignKey(p => p.SubjectId);


            builder.Entity<CollageAdmins> (x => x.HasKey(p => new { p.CollageId , p.UserId}));

            builder.Entity<CollageAdmins> ()
            .HasOne(u => u.College)
            .WithMany(u => u.CollageAdmins)
            .HasForeignKey(p => p.CollageId);

            builder.Entity<CollageAdmins> ()
            .HasOne(u => u.User)
            .WithMany(u => u.CollageAdmins)
            .HasForeignKey(p => p.UserId);

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