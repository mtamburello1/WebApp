using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Opere
{
    public class DeleteModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public DeleteModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Opera Opera { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Opera = await _context.Opera
                .Include(o => o.Autore).FirstOrDefaultAsync(m => m.OperaId == id);

            if (Opera == null)
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

            Opera = await _context.Opera.FindAsync(id);

            if (Opera != null)
            {
                _context.Opera.Remove(Opera);
                if (this.Opera.FotoOpera != null)
                { 
                    System.IO.File.Delete("wwwroot/img/" + this.Opera.FotoOpera);                
                }
                if (this.Opera.VideoOpera != null)
                { 
                    System.IO.File.Delete("wwwroot/img/VideoOpere/" + this.Opera.VideoOpera);
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
