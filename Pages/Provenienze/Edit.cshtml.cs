using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models.Entities.BiancoENero;

namespace WebApp.Pages.Provenienze
{
    public class EditModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public EditModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Provenienza Provenienza { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Provenienza = await _context.Provenienza
                .Include(p => p.Vino).FirstOrDefaultAsync(m => m.ProvenienzaId == id);

            if (Provenienza == null)
            {
                return NotFound();
            }
           ViewData["VinoId"] = new SelectList(_context.Vino, "NomeVino", "NomeVino");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["VinoId"] = new SelectList(_context.Vino, "NomeVino", "NomeVino");
                return Page();
            }

            _context.Attach(Provenienza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvenienzaExists(Provenienza.ProvenienzaId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProvenienzaExists(long id)
        {
            return _context.Provenienza.Any(e => e.ProvenienzaId == id);
        }
    }
}
