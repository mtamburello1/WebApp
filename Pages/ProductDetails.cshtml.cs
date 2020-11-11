using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp.Pages
{
    public class ProductDetailsModel : PageModel
    {

        private readonly ILogger<PrivacyModel> _logger;

        public ProductDetailsModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {


        }
    }
}
