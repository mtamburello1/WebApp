using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models.Entities.BiancoENero;

namespace WebApp.Pages.Vini
{
    [BindProperties(SupportsGet = true)]
    public class DetailsModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public DetailsModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public Vino Vino { get; set; }
        public IList<string> Zone { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vino = await _context.Vino
                .Include(v => v.ZoneVini)
                .FirstOrDefaultAsync(m => m.NomeVino == id);

            foreach (var item in Vino.ZoneVini) {
                Zone.Add(item.NomeZona);
            }

            if (Vino == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
