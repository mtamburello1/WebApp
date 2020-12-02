using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Opere
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
        ViewData["AutoreId"] = new SelectList(_context.Autore, "AutoreId", "NomeAutore");
            return Page();
        }

        [BindProperty]
        public Opera Opera { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        ViewData["AutoreId"] = new SelectList(_context.Autore, "AutoreId", "NomeAutore");
        //        return Page();
        //    }

        //    _context.Opera.Add(Opera);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}

        public async Task<IActionResult> OnPostUploadAsync(IFormFile fotoOpera, IFormFile videoOpera)
        {
            if (!ModelState.IsValid)
            {
                ViewData["AutoreId"] = new SelectList(_context.Autore, "AutoreId", "NomeAutore");
                return Page();
            }

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
                }
            }



            _context.Opera.Add(Opera);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }



    }
}
