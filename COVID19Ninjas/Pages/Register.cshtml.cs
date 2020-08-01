using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19Relief.Middleware.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace COVID19Ninjas.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private SterlingMobile.Services.DataService dataService;

        [BindProperty]
        public Users Users { get; set; }

        public static Users UsersData { get; set; }
        [BindProperty]
        public SalaryDetails SalaryDetails { get; set; }
        [BindProperty]
        public SalaryWorkersDetails SalaryWorkersDetails { get; set; }
        [BindProperty]
        public SelfEmployedWorkersDetails SelfEmployed { get; set; }
        private Banks GetBanks { get; set; }

        public bool showUserInfo { get; set; }

        public bool showEmploymentInfo { get; set; }

        public bool showIndemnityInfo { get; set; }

        public bool showThanksInfo { get; set; }

        public RegisterModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
            dataService = new SterlingMobile.Services.DataService();
        }

        public async Task OnGetAsync()
        {
            showUserInfo = true;
            //var banks =  await  dataService.GetData<List<Banks>>("api/Banks");

        }



        public async Task OnPostAsyncGoToEmploymentInfo()
        {
            await Task.Delay(1);
            showUserInfo = false;
            showEmploymentInfo = true;

        }

        public async Task OnPostGoToIndemnifier()
        {
            await Task.Delay(1);
            showEmploymentInfo = false;
            showIndemnityInfo = true;

        }

        public void OnPostGoToEmploymentInfo()
        {
            UsersData = Users;
            showUserInfo = false;
            showEmploymentInfo = true;
        }


        public IActionResult OnPostGoToDashBoard()
        {
            return RedirectToPage("Dashboard", "InitValidation", new { email = UsersData.Email, phone = UsersData.PhoneNumber, name = UsersData.FirstName + " " + UsersData.LastName });

            //return new RedirectToPageResult($"Dashboard?users=test");
        }


        public async Task OnPostAsyncGoToThankYou()
        {
            await Task.Delay(1);
            showThanksInfo = false;
            showIndemnityInfo = false;

        }

        //public async Task OnPostGoToPerfValidate()
        //{
        //    await Task.Delay(1);
        //    //RedirectToAction("Dashboard", "Client");
        //    //RedirectToPage("/Index");

        //}



        public async Task<RedirectToPageResult> OnPostGoToPerfValidate()
        {
            await Task.Delay(1);

            return new RedirectToPageResult("../Views/Client/Dashboard");
            //RedirectToPage("/Index");

        }


    }
}
