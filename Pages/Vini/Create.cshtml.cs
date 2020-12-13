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
    [BindProperties(SupportsGet = true)]
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

        public IEnumerable<string> Zone { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["Zone"] = new SelectList(_context.Zona, "NomeZona", "NomeZona");
                return Page();
            }

            foreach (var nomeZona in Zone)
            {
                var zona = _context.Zona.FirstOrDefault(x => x.NomeZona.Equals(nomeZona));
                var zonaVino = new ZonaVino(zona, this.Vino);
                this.Vino.ZoneVini.Add(zonaVino);
            }
           
            _context.Vino.Add(Vino);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
