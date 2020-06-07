using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        BookName = "1 Nephi",
                        DateAdded = DateTime.Parse("2020-2-12"),
                        Chapter = 1,
                        Verse = 1,
                        Note = "This is the first chapter."
                    },

                    new Book
                    {
                        BookName = "2 Nephi",
                        DateAdded = DateTime.Parse("2020-2-12"),
                        Chapter = 2,
                        Verse = 1,
                        Note = "This is the Second chapter."
                    },

                    new Book
                    {
                        BookName = "Alma",
                        DateAdded = DateTime.Parse("2020-2-12"),
                        Chapter = 3,
                        Verse = 1,
                        Note = "This is the Third chapter."
                    },

                    new Book
                    {
                        BookName = "Moroni",
                        DateAdded = DateTime.Parse("2020-2-12"),
                        Chapter = 1,
                        Verse = 1,
                        Note = "This is the first chapter."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
