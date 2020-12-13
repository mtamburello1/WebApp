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

namespace WebApp.Pages.Vini
{
    [BindProperties(SupportsGet = true)]
    public class EditModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public EditModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public Vino Vino { get; set; }
        public IEnumerable<string> Zone { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vino = await _context.Vino
                .Include(v=> v.ZoneVini)
                .FirstOrDefaultAsync(m => m.NomeVino == id);

            ViewData["Zone"] = new SelectList(_context.Zona, "NomeZona", "NomeZona");

            if (Vino == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["Zone"] = new SelectList(_context.Zona, "NomeZona", "NomeZona");
                return Page();
            }

            _context.Attach(Vino).State = EntityState.Modified;

            if (Zone != null)
            {
                ChangeZone();
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return RedirectToPage("./Index");
        }


        private void ChangeZone() {
            IList<ZonaVino> z = _context.ZonaVino
                .Where(x => x.NomeVino.Equals(Vino.NomeVino))
                .ToList();

            foreach (var item in z)
            {
                _context.ZonaVino.Remove(item);
            }

            Vino.ZoneVini = new HashSet<ZonaVino>();
            foreach (var nomeZona in Zone)
            {
                var zona = _context.Zona.FirstOrDefault(x => x.NomeZona.Equals(nomeZona));
                var zonaVino = new ZonaVino(zona, this.Vino);
                this.Vino.ZoneVini.Add(zonaVino);
            }
        }
    }
}
