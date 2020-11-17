using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Recensioni
{
    public class DeleteModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public DeleteModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recensione Recensione { get; set; }
        public Opera Opera { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recensione = await _context.Recensione
                .Include(r => r.Opera)
                .FirstOrDefaultAsync(m => m.RecensioneId == id);

            if (Recensione == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recensione = await _context.Recensione
                .FindAsync(id);

            Opera= await _context.Opera
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.OperaId == Recensione.OperaId);

            if (Recensione != null && Opera !=null)
            {
                UpdateOpera();
                _context.Attach(Opera).State = EntityState.Modified;
                _context.Recensione.Remove(Recensione);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }


        private void UpdateOpera()
        {

            Opera.NumeroVoti--;

            if (Recensione.ValoreRecensione == 1)
            {
                Opera.OneStars -= 1;
            }
            else if (Recensione.ValoreRecensione == 2)
            {
                Opera.TwoStars -= 1;
            }
            else if (Recensione.ValoreRecensione == 3)
            {
                Opera.ThreeStars -= 1;
            }
            else if (Recensione.ValoreRecensione == 4)
            {
                Opera.FourStars -= 1;
            }
            else if (Recensione.ValoreRecensione == 5)
            {
                Opera.FiveStars -= 1;
            }

            Opera.Voto = (Opera.OneStars + (Opera.TwoStars * 2) + (Opera.ThreeStars * 3) + (Opera.FourStars * 4) + (Opera.FiveStars * 5)) / Opera.NumeroVoti;

        }
    }
}
