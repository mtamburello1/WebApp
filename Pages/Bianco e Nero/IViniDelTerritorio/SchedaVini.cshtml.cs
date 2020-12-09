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

namespace WebApp.Pages.Bianco_e_Nero.IViniDelTerritorio
{
    public class SchedaViniModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public SchedaViniModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public IList<Vino> ListaVini { get; set; }
        public Vino Vino { get; set; }
        public IList<ZonaVino> ZoneVini { get; set; }

        public async Task OnGet()
        {
            String tipo = Request.Query["id"].ToString();

            ListaVini = await _context.Vino
            .Where(v => v.TipoVino.Equals(tipo))
            .AsNoTracking()
            .ToListAsync();

            ViewData["Vini"] = ListaVini;

        }

        public async Task<IActionResult> OnPostSend()
        {
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
                        Vino = await _context.Vino
                        .AsNoTracking()
                        .FirstOrDefaultAsync(v => v.TipoVino.Equals(obj.Item2) & v.NomeVino.Equals(obj.Item1));

                    }
                }
            }
            List<string> dati = new List<string>
            {
                Vino.StoriaVino,
                Vino.CaratteristicheVino
            };
            return new JsonResult(dati);
        }

    }
    public class PostData
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }
    }

    
}


