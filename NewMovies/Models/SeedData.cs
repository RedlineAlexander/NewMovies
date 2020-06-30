using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewMovies.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewMovies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NewMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<NewMoviesContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(

                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Infinity",
                        ReleaseDate = DateTime.Parse("1990-1-12"),
                        Genre = "Phantasy",
                        Price = 6.99M

                    },
                    new Movie
                    {
                        Title = "The Bad Guy",
                        ReleaseDate = DateTime.Parse("2019-09-2"),
                        Genre = "Musician Film",
                        Price = 9.88M
                    },

                    new Movie
                    {
                        Title = "The 8 Mile",
                        ReleaseDate = DateTime.Parse("2002-09-1"),
                        Genre = "Action History",
                        Price = 500M
                    }
                    )  ;
                context.SaveChanges();

            }
        }
    }
}
