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
    public class CreateModel : PageModel
    {

        public SelectList ScriptureBooks { get; set; }

        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public CreateModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from m in _context.Book
                                           select m.Name;
            var scriptures = from m in _context.JournalEntry
                             select m;
            ScriptureBooks = new SelectList(await bookQuery.ToListAsync());
        }

       /* public IActionResult OnGet()
        {
            return Page();
        }*/

        [BindProperty]
        public JournalEntry JournalEntry { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JournalEntry.Add(JournalEntry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}