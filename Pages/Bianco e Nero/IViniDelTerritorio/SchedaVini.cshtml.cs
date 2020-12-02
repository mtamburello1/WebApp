using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

        public IList<Vino> Vini { get; set; }
        public IList<Provenienza> Provenienze { get; set; }

        public async Task OnGet()
        {
            String tipo = Request.Query["id"].ToString();
            if (tipo.Equals("rosso") || tipo.Equals("bianco")) {
                ViewData["tipo"] = tipo;
                Vini = await _context.Vino
                .Where(v => v.TipoVino.Equals(tipo))
                .Include(v => v.Provenienze)
                .AsNoTracking()
                .ToListAsync();



            }
            else {
                NotFound();
            }
            
        }
    }
}
