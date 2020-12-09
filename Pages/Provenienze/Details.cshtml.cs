﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models.Entities.BiancoENero;

namespace WebApp.Pages.Provenienze
{
    public class DetailsModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public DetailsModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public Provenienza Provenienza { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Provenienza = await _context.Provenienza
                .Include(p => p.Vino).FirstOrDefaultAsync(m => m.ProvenienzaId == id);

            if (Provenienza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}