using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Data;
using WebApp.Models.Entities.BiancoENero;

namespace WebApp.Pages.Vini
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
            ViewData["Zone"]= new SelectList(_context.Zona, "NomeZona", "NomeZona");
            return Page();
        }

        public Vino Vino { get; set; }
        public ZonaVino Provenienza { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           
            _context.Vino.Add(Vino);
            _context.ZonaVino.Add(Provenienza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
