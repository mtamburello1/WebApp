using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace WebApp.Pages.Autori
{
    public class EditModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public EditModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Autore Autore { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Autore = await _context.Autore.FirstOrDefaultAsync(m => m.AutoreId == id);

            if (Autore == null)
            {
                return NotFound();
            }

            HttpContext.Session.SetString("videoCorrente", this.Autore.VideoAutore);
            HttpContext.Session.SetString("fotoCorrente", this.Autore.FotoAutore);
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostUploadAsync(IFormFile fotoAutore, IFormFile videoAutore) 
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Autore).State = EntityState.Modified;

            if (fotoAutore != null)
            {
                if (fotoAutore.Length > 0)
                {
                    //Prende il nome del file
                    var fileName = Path.GetFileName(fotoAutore.FileName);

                    //Assegna un nome univoco per il file
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Prende l'estensione del file
                    var fileExtension = Path.GetExtension(fileName);

                    // Concatena file e estensione
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    // Combina il file col path
                    var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "Autori")).Root + $@"\{newFileName}";

                    // Crea il path da salvare nel DB
                    this.Autore.FotoAutore = newFileName;

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        fotoAutore.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }

            if (videoAutore != null)
            {
                if (videoAutore.Length > 0)
                {
                    //Prende il nome del file
                    var fileName = Path.GetFileName(videoAutore.FileName);

                    //Assegna un nome univoco per il file
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Prende l'estensione del file
                    var fileExtension = Path.GetExtension(fileName);

                    // Concatena file e estensione
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    // Combina il file col path
                    var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "VideoAutori")).Root + $@"\{newFileName}";

                    // Crea il path da salvare nel DB
                    this.Autore.VideoAutore = newFileName;

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        videoAutore.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }


            if (this.Autore.VideoAutore == null) {
                this.Autore.VideoAutore = HttpContext.Session.GetString("videoCorrente");
            }

            if (this.Autore.FotoAutore == null)
            {
                this.Autore.FotoAutore = HttpContext.Session.GetString("fotoCorrente");
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoreExists(Autore.AutoreId))
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

        private bool AutoreExists(long id)
        {
            return _context.Autore.Any(e => e.AutoreId == id);
        }
    }
}
