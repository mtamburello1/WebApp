using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Pages
{
    public class AutoreModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public AutoreModel(WebApp.Data.WebAppContext context)
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
                .Include(o => o.Autore)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.OperaId == id);

            if (Opera == null || Opera.Autore == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
