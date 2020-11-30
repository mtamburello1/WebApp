using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Pages
{
    public class AggiuntaRecensioneModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public AggiuntaRecensioneModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(long? id)

        {
            if (id == null)
            {
                ViewData["OperaId"] = new SelectList(_context.Opera, "OperaId", "Titolo", " ");
                return Page();
            }

            ViewData["OperaId"] = new SelectList(_context.Opera, "OperaId", "Titolo", id);
            return Page();
        }
        

        [BindProperty]
        public Recensione Recensione { get; set; }
        public Opera Opera { get; set; }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recensione.Add(Recensione);

            Opera= await _context.Opera
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.OperaId == id);
            
            UpdateOpera();

            _context.Attach(Opera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperaExists(Opera.OperaId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private void UpdateOpera() {

            Opera.NumeroVoti++;

            if (Recensione.ValoreRecensione == 1) {
                Opera.OneStars += 1;
            }
            else if (Recensione.ValoreRecensione == 2)
            {
                Opera.TwoStars += 1;
            }
            else if (Recensione.ValoreRecensione == 3)
            {
                Opera.ThreeStars += 1;
            }
            else if (Recensione.ValoreRecensione == 4)
            {
                Opera.FourStars += 1;
            }
            else if (Recensione.ValoreRecensione == 5)
            {
                Opera.FiveStars += 1;
            }

        }


        private bool OperaExists(long id)
        {
            return _context.Opera.Any(e => e.OperaId == id);
        }
    }
}
