using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Pages
{
    public class ReviewsModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public ReviewsModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public Opera Opera { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Opera = await _context.Opera
                .Include(o => o.Recensioni)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.OperaId == id);

            if (Opera == null)
            {
                return NotFound();
            }

            ViewData["NumeroVoti"] = Opera.NumeroVoti;

            if (Opera.NumeroVoti != 0)
            {
                ViewData["Voto"] = (Opera.OneStars + (Opera.TwoStars * 2) + (Opera.ThreeStars * 3) + (Opera.FourStars * 4) + (Opera.FiveStars * 5)) / Opera.NumeroVoti;
                ViewData["OneStars"] = ((Opera.OneStars * 100) / Opera.NumeroVoti);
                ViewData["TwoStars"] = ((Opera.TwoStars * 100) / Opera.NumeroVoti);
                ViewData["ThreeStars"] = ((Opera.ThreeStars * 100) / Opera.NumeroVoti);
                ViewData["FourStars"] = ((Opera.FourStars * 100) / Opera.NumeroVoti);
                ViewData["FiveStars"] = ((Opera.FiveStars * 100) / Opera.NumeroVoti);
            }

            else {
                ViewData["Voto"] = 0;
                ViewData["OneStars"] = 0;
                ViewData["TwoStars"] = 0;
                ViewData["ThreeStars"] = 0;
                ViewData["FourStars"] = 0;
                ViewData["FiveStars"] = 0;
            }


            return Page();
        }


    }
}
