using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Personaggi
{
    public class EditModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public EditModel(WebApp.Data.WebAppContext context)
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

           ViewData["OperaId"] = new SelectList(_context.Opera, "OperaId", "Titolo", Personaggio.Opera.Titolo);

            if (this.Personaggio.VideoPersonaggio != null)
            {
                HttpContext.Session.SetString("videoCorrente", this.Personaggio.VideoPersonaggio);
            }

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostUploadAsync(IFormFile videoPersonaggio)
        {
            if (!ModelState.IsValid)
            {
                ViewData["OperaId"] = new SelectList(_context.Opera, "OperaId", "Titolo");
                return Page();
            }

            _context.Attach(Personaggio).State = EntityState.Modified;

            if (videoPersonaggio != null)
            {
                if (videoPersonaggio.Length > 0)
                {
                    //Prende il nome del file
                    var fileName = Path.GetFileName(videoPersonaggio.FileName);

                    //Assegna un nome univoco per il file
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Prende l'estensione del file
                    var fileExtension = Path.GetExtension(fileName);

                    // Concatena file e estensione
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    // Combina il file col path
                    var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "VideoPersonaggi")).Root + $@"\{newFileName}";

                    // Crea il path da salvare nel DB
                    this.Personaggio.VideoPersonaggio = newFileName;

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        videoPersonaggio.CopyTo(fs);
                        fs.Flush();
                    }

                    if (HttpContext.Session.GetString("videoCorrente") != null)
                    {
                        System.IO.File.Delete("wwwroot/img/VideoPersonaggi/" + HttpContext.Session.GetString("videoCorrente"));
                    }

                }
            }

            if (this.Personaggio.VideoPersonaggio == null)
            {
                this.Personaggio.VideoPersonaggio = HttpContext.Session.GetString("videoCorrente");
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaggioExists(Personaggio.PersonaggioId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PersonaggioExists(long id)
        {
            return _context.Personaggio.Any(e => e.PersonaggioId == id);
        }
    }
}
