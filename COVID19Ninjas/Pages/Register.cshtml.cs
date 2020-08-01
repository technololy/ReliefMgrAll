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
        public static Users usersStaticData { get; set; }
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
            usersStaticData = Users;

            showUserInfo = false;
            showEmploymentInfo = true;
        }


        public async Task OnPostAsyncGoToThankYou()
        {
            await Task.Delay(1);
            showThanksInfo = false;
            showIndemnityInfo = false;

        }

        public IActionResult OnPostGoToValidationPage()
        {
            return new RedirectToPageResult("Validation", new { usersEmail = usersStaticData.Email, usersPhone = usersStaticData.PhoneNumber, usersFullName = usersStaticData.FirstName + " " + usersStaticData.MiddleName + " " + usersStaticData.LastName });
        }


    }
}
