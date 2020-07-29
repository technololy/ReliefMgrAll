using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19Ninjas.Views.Shared
{
    public class _ClientLayout: PageModel
    {
        private readonly ILogger<_ClientLayout> _logger;

        public _ClientLayout(ILogger<_ClientLayout> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
