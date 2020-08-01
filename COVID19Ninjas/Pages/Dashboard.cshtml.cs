using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19Ninjas.Models;
using COVID19Relief.Middleware.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SterlingMobile.Services;

namespace COVID19Ninjas.Pages
{
    public class DashboardModel : PageModel
    {
        [BindProperty]
        public string UsersEmail { get; private set; }
        [BindProperty]

        public string UsersPhone { get; private set; }
        [BindProperty]

        public string UsersName { get; private set; }
        [BindProperty]

        public string UsersTrnxRef { get; private set; }


        public static string _UsersEmail { get; private set; }
        public static string _UsersPhone { get; private set; }
        public static string _UsersName { get; private set; }
        public static string _UsersTrnxRef { get; private set; }

        public void OnGet()
        {

        }

        public void OnGetInitValidation(string email, string phone, string name)
        {
            UsersEmail = _UsersEmail = email;
            UsersPhone = _UsersPhone = phone;
            UsersName = _UsersName = name;
            UsersTrnxRef = _UsersTrnxRef = email + DateTime.Now.ToString();
            HttpContext.Session.SetString("usersEmail", _UsersEmail);
            HttpContext.Session.SetString("usersPhone", _UsersPhone);
            HttpContext.Session.SetString("usersName", _UsersName);
            HttpContext.Session.SetString("usersTrnx", _UsersTrnxRef);
        }

        public async Task<IActionResult> OnPostDoEnableValidation()
        {
            Models.FWRequest fWRequest = new Models.FWRequest()
            {
                tx_ref = $"{UsersEmail}_{DateTime.Now}",
                amount = "1",
                currency = "NGN",
                redirect_url = "https://localhost:5001/RedirectFromFlutterWave",
                payment_options = "card,ussd",
                customer = new Models.Customer()
                {
                    email = UsersEmail,
                    phonenumber = UsersPhone,
                    name = UsersName
                },
                customizations = new Models.Customizations()
                {
                    title = "Relief Manager",
                    description = "Helping during pandemics",
                    logo = "https://assets.piedpiper.com/logo.png"
                }

            };

            string endpoint = "https://api.flutterwave.com/v3/payments";

            APIService api = new APIService("");
            var response = await api.PostUpdated<FWStandardPaymentResponse>(fWRequest, endpoint);

            if (response.isSuccess)
            {
                return new RedirectToPageResult("LoadFWIFrame", "PaymentURL", new { url = response.obj.data.link });

            }
            else
            {
                return null;

            }

        }


        public void OnPostGoToValidation()
        {

        }

        public void OnGetReturnFromFW(string tx_ref)
        {



        }
    }
}
