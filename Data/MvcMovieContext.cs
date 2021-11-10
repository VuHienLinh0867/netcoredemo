using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DEMONETCORE.Models;
using DEMONETCORE.Data;
namespace DEMONETCORE.Data
{
     public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<DEMONETCORE.Models.Person> Person { get; set; }

        public DbSet<DEMONETCORE.Models.Student> Student { get; set; }

        public DbSet<DEMONETCORE.Models.Employee> Employee { get; set; }

        public DbSet<DEMONETCORE.Models.Product> Product { get; set; }
    }
}
    

   
