using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScriptureJournal.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }
        public IList<Book> Book { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList BookName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BName { get; set; }

        public string NameSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            IQueryable<string> bookQuery = from m in _context.Book
                                           orderby m.BookName
                                           select m.BookName;
            var books = from m in _context.Book
                        select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.Note.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(BName))
            {
                books = books.Where(x => x.BookName == BName);
            }

            BookName = new SelectList(await bookQuery.Distinct().ToListAsync());
            Book = await books.ToListAsync();

            // sorting book by name and date added.

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            switch (sortOrder)
            {
                case "name_desc":
                    books = books.OrderByDescending(s => s.BookName);
                    break;
                case "Date":
                    books = books.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    books = books.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    books = books.OrderBy(s => s.BookName);
                    break;
            }
            Book = await books.AsNoTracking().ToListAsync();
        }
    }
}
