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

        public IList<String> ListaVini { get; set; }
        public Vino Vino { get; set; }
        public IList<Provenienza> Provenienze { get; set; }

        public async Task OnGet()
        {
            /*provare a mettere l'id nel get*/
            String tipo = Request.Query["id"].ToString();
            
            ListaVini= await _context.Vino
            .Where(v => v.TipoVino.Equals(tipo))
            .Select(v => v.NomeVino)
            .AsNoTracking()
            .ToListAsync();

            ViewData["Vini"] = ListaVini;
            
        }

        public async void OnPostWinesAsync(string Nome)
        {
            Console.WriteLine("sono dentro");
            Vino= await _context.Vino
            .AsNoTracking()
            .FirstOrDefaultAsync(v => v.NomeVino.Equals(Nome));

            ViewData["Storia"] = Vino.StoriaVino;
            ViewData["Caratteristiche"] = Vino.CaratteristicheVino;

            Provenienze = await _context.Provenienza
            .Where(p => p.NomeVino.Equals(Vino.NomeVino))
            .AsNoTracking()
            .ToListAsync();

        }
    }
}
