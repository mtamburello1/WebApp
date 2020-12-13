using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApp.Models.Entities.BiancoENero;

namespace WebApp.Pages.Bianco_e_Nero.GiocareConIlVino
{
    public class RiConosciIViniPlayModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public RiConosciIViniPlayModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public IList<Vino> ListaVini { get; set; }
        public IList<string> ZoneVino { get; set; }

        public async Task OnGet()
        {
            String tipo = Request.Query["id"].ToString();

            ListaVini = await _context.Vino
            .Where(v => v.TipoVino.Equals(tipo))
            .AsNoTracking()
            .ToListAsync();

            ViewData["Vini"] = ListaVini;

        }

        public async Task<IActionResult> OnPostCheck()
        {
            Boolean contains = false;
            MemoryStream stream = new MemoryStream();
            Request.Body.CopyTo(stream);
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream))
            {
                string requestBody = reader.ReadToEnd();
                if (requestBody.Length > 0)
                {
                    var obj = JsonConvert.DeserializeObject<PostData>(requestBody);
                    if (obj != null)
                    {
                        ZoneVino = await _context.ZonaVino
                        .Include(v=>v.Vino)
                        .Where(z => z.Vino.TipoVino.Equals(obj.Item2) & z.NomeVino.Equals(obj.Item1))
                        .Select(z => z.NomeZona)
                        .ToListAsync();

                        if (ZoneVino.Contains(obj.Item3)) {
                            contains=true;
                        }

                    }
                }
            }
            
            return new JsonResult(contains);
        }

    }
    public class PostData
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
    }
}

