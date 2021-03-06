﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Opere
{
    public class IndexModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public IndexModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public IList<Opera> Opera { get;set; }

        public async Task OnGetAsync()
        {
            Opera = await _context.Opera
                .Include(o => o.Autore)
                .AsNoTracking()
                .ToListAsync();
        }
    }   
}
