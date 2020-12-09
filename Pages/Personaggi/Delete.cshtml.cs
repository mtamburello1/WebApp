using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Personaggi
{
    public class DeleteModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public DeleteModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Personaggio Personaggio { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Personaggio = await _context.Personaggio
                .Include(p => p.Opera).FirstOrDefaultAsync(m => m.PersonaggioId == id);

            if (Personaggio == null)
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

            Personaggio = await _context.Personaggio.FindAsync(id);

            if (Personaggio != null)
            {
                _context.Personaggio.Remove(Personaggio);
                if (this.Personaggio.VideoPersonaggio != null) { 
                    System.IO.File.Delete("wwwroot/img/VideoPersonaggi/" + this.Personaggio.VideoPersonaggio);
                }                
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
