using Microsoft.EntityFrameworkCore;
using NewMovies.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace NewMovies.Data
{
    public class NewMoviesContext : DbContext
    {
        public NewMoviesContext(DbContextOptions<NewMoviesContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }

    /////    protected override void OnModelCreating(DbModelBuilder modelBuilder)
     //  {
//
    //    }

    }
}
