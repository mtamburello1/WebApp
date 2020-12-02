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

namespace WebApp.Pages.Opere
{
    public class EditModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public EditModel(WebApp.Data.WebAppContext context)
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
           ViewData["AutoreId"] = new SelectList(_context.Autore, "AutoreId", "NomeAutore");

            if (this.Opera.FotoOpera != null)
            {
                HttpContext.Session.SetString("fotoCorrente", this.Opera.FotoOpera);
            }

            if (this.Opera.VideoOpera != null)
            {

                HttpContext.Session.SetString("videoCorrente", this.Opera.VideoOpera);
            }



            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostUploadAsync(IFormFile fotoOpera, IFormFile videoOpera)
        {
            if (!ModelState.IsValid)
            {
                ViewData["AutoreId"] = new SelectList(_context.Autore, "AutoreId", "NomeAutore");
                return Page();
            }

            _context.Attach(Opera).State = EntityState.Modified;

            if (fotoOpera != null)
            {
                if (fotoOpera.Length > 0)
                {
                    //Prende il nome del file
                    var fileName = Path.GetFileName(fotoOpera.FileName);

                    //Assegna un nome univoco per il file
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Prende l'estensione del file
                    var fileExtension = Path.GetExtension(fileName);

                    // Concatena file e estensione
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    // Combina il file col path
                    var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img")).Root + $@"\{newFileName}";

                    // Crea il path da salvare nel DB
                    this.Opera.FotoOpera = newFileName;

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        fotoOpera.CopyTo(fs);
                        fs.Flush();
                    }

                    if (HttpContext.Session.GetString("fotoCorrente") != null)
                    {
                        System.IO.File.Delete("wwwroot/img/" + HttpContext.Session.GetString("fotoCorrente"));
                    }


                }
            }

            if (videoOpera != null)
            {
                if (videoOpera.Length > 0)
                {
                    //Prende il nome del file
                    var fileName = Path.GetFileName(videoOpera.FileName);

                    //Assegna un nome univoco per il file
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Prende l'estensione del file
                    var fileExtension = Path.GetExtension(fileName);

                    // Concatena file e estensione
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    // Combina il file col path
                    var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "VideoOpere")).Root + $@"\{newFileName}";

                    // Crea il path da salvare nel DB
                    this.Opera.VideoOpera = newFileName;

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        videoOpera.CopyTo(fs);
                        fs.Flush();
                    }


                    if (HttpContext.Session.GetString("videoCorrente") != null)
                    {
                        System.IO.File.Delete("wwwroot/img/VideoOpere/" + HttpContext.Session.GetString("videoCorrente"));
                    }

                }
            }

            if (this.Opera.VideoOpera == null)
            {
                this.Opera.VideoOpera = HttpContext.Session.GetString("videoCorrente");
            }

            if (this.Opera.FotoOpera == null)
            {
                this.Opera.FotoOpera = HttpContext.Session.GetString("fotoCorrente");
            }


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperaExists(Opera.OperaId))
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

        private bool OperaExists(long id)
        {
            return _context.Opera.Any(e => e.OperaId == id);
        }
    }
}
