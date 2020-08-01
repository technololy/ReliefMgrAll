using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19Ninjas.Pages
{
    public class RedirectFromFlutterWaveModel : PageModel
    {
        public IActionResult OnGet(string tx_ref, string transaction_id, string status)
        {
            if (status.ToLower() == "successful")
            {
                return RedirectToPage("Dashboard");
            }
            else
            {
                return RedirectToPage("Dashboard");

                //return new RedirectToPageResult("Dashboard");

            }
        }
    }
}
