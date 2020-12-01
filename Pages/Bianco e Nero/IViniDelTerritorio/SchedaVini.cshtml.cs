using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Bianco_e_Nero.IViniDelTerritorio
{
    public class SchedaViniModel : PageModel
    {
        public void OnGet()
        {
            if (Request.Query["id"].ToString().Equals("rosso"))
            {
                ViewData["tipo"] = "rosso";
            }
            else 
            {
                ViewData["tipo"] = "bianco";
            }
        }
    }
}
