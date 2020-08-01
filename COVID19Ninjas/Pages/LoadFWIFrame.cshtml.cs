using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19Ninjas.Pages
{
    public class LoadFWIFrameModel : PageModel
    {
        [BindProperty]
        public string PaymentURL { get; set; }

        public void OnGet()
        {
        }


        public IActionResult OnPostGoBack()
        {
            return new RedirectToPageResult("Dashboard");
        }


        public void OnGetPaymentURL(string url)
        {
            PaymentURL = url;
        }

        public IActionResult OnGetReturnFromFW(string tx_ref, string transaction_id, string status)
        {
            if (status.ToLower() == "successful")
            {
                return new RedirectToPageResult("Dashboard");
            }
            else
            {
                return new RedirectToPageResult("Dashboard");

            }
        }
    }
}
