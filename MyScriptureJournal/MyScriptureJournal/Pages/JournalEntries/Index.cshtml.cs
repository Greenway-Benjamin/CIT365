using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.JournalEntries
{
    public class IndexModel : PageModel
    {

        public string DateSort { get; set; }
        public string BookSort { get; set; }
        public string CurrentSort { get; set; }

        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntry { get;set; }

        [BindProperty(SupportsGet = true)]
        public string Book { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Notes { get; set; }

        public SelectList ScriptureBooks { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {

            IQueryable<string> bookQuery = from m in _context.Book
                                           select m.Name;
            var scriptures = from m in _context.JournalEntry
                             select m;

            BookSort = sortOrder == "name_asc" ? "name_desc" : "name_asc";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            switch (sortOrder)
            {
                case "name_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;

                case "name_asc":
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;

                case "Date":
                    scriptures = scriptures.OrderBy(s => s.Date);
                    break;
                    
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Date);
                    break;
            }


            
            if (!string.IsNullOrEmpty(Book))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(Book));
            }

            if (!string.IsNullOrEmpty(Notes))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(Notes));
            }

            ScriptureBooks = new SelectList(await bookQuery.ToListAsync());
            JournalEntry = await scriptures.ToListAsync();
        }
    }
}
