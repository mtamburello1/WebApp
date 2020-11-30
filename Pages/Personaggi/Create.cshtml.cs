using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Personaggi
{
    public class CreateModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public CreateModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["OperaId"] = new SelectList(_context.Opera, "OperaId", "Titolo");
            return Page();
        }

        [BindProperty]
        public Personaggio Personaggio { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["OperaId"] = new SelectList(_context.Opera, "OperaId", "Titolo");
                return Page();
            }

            _context.Personaggio.Add(Personaggio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
