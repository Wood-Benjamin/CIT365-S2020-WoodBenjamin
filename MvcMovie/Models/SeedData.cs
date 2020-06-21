using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Adventure/Drama",
                        Price = 2.99M,
                        Rating = "PG",
                        UploadPath = "uploads/other-side-heaven.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 3.99M,
                        Rating = "PG",
                        UploadPath = "uploads/meet-the-mormons.jpg"
                    },

                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-7-24"),
                        Genre = "Drama",
                        Price = 3.99M,
                        Rating = "PG",
                        UploadPath = "uploads/the-fighting-preacher.jpg"
                    },

                    new Movie
                    {
                        Title = "The Cokeville Miracle",
                        ReleaseDate = DateTime.Parse("2015-6-5"),
                        Genre = "Drama/Mystery",
                        Price = 1.99M,
                        Rating = "PG-13",
                        UploadPath = "uploads/the-cokeville-miracle.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
