using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.models;
using Microsoft.EntityFrameworkCore;


namespace api.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) :base(dbContextOptions)

        {
            
        }
        public DbSet<User> Users {get;set;}
        public DbSet<College> College {get;set;}
        public DbSet<Semester> semester {get;set;}

    }
}