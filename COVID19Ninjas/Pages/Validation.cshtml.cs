using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19Ninjas.Pages
{
    public class ValidationModel : PageModel
    {
        [BindProperty]
        public string usersEmail { get; set; }
        [BindProperty]

        public string usersPhone { get; set; }
        [BindProperty]

        public string usersFullName { get; set; }
        [BindProperty]

        public string usersTrnx { get; set; }

        private static string _usersEmail;
        private static string _usersPhone;
        private static string _usersFullName;
        public void OnGet(string usersEmail, string usersPhone, string usersFullName)
        {
            //assign to static properties once
            if (string.IsNullOrEmpty(_usersEmail) && !string.IsNullOrEmpty(usersEmail))
            {
                _usersEmail = usersEmail;
            }

            if (string.IsNullOrEmpty(_usersPhone) && !string.IsNullOrEmpty(usersPhone))
            {
                _usersPhone = usersPhone;
            }

            if (string.IsNullOrEmpty(_usersFullName) && !string.IsNullOrEmpty(usersFullName))
            {
                _usersFullName = usersFullName;
            }
            //on page load keep assigning to binded properties from static properties
            if (string.IsNullOrEmpty(this.usersEmail) && !string.IsNullOrEmpty(_usersEmail))
            {
                this.usersEmail = _usersEmail;
            }

            if (string.IsNullOrEmpty(this.usersPhone) && !string.IsNullOrEmpty(_usersPhone))
            {
                this.usersPhone = _usersPhone;
            }

            if (string.IsNullOrEmpty(this.usersFullName) && !string.IsNullOrEmpty(_usersFullName))
            {
                this.usersFullName = _usersFullName;
            }

            usersTrnx = this.usersFullName + DateTime.Now.ToString();


        }



        public void OnGetReturnFromFW(string tx_ref)
        {

        }
    }
}
