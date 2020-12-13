using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Pages
{
    public class ListaPersonaggiModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public ListaPersonaggiModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public Opera Opera { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Opera = await _context.Opera
                .Include(p => p.Personaggi)
                .FirstOrDefaultAsync(m => m.OperaId == id);

            if (Opera == null || Opera.Personaggi == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
