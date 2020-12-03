using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Data;
using WebApp.Models.Entities.BiancoENero;

namespace WebApp.Pages.Provenienze
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
            ViewData["VinoId"] = new SelectList(_context.Vino, "NomeVino", "NomeVino");
            return Page();
        }

        [BindProperty]
        public Provenienza Provenienza { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["VinoId"] = new SelectList(_context.Vino, "NomeVino", "NomeVino");
                return Page();
            }

            _context.Provenienza.Add(Provenienza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
