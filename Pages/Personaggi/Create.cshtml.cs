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

namespace WebApp.Pages.Personaggi
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
            ViewData["OperaId"] = new SelectList(_context.Opera, "OperaId", "Titolo");
            return Page();
        }

        [BindProperty]
        public Personaggio Personaggio { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        ViewData["OperaId"] = new SelectList(_context.Opera, "OperaId", "Titolo");
        //        return Page();
        //    }

        //    _context.Personaggio.Add(Personaggio);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}

        public async Task<IActionResult> OnPostUploadAsync(IFormFile videoPersonaggio)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

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
                }
            }


            _context.Personaggio.Add(Personaggio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
