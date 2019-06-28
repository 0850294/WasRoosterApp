using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WasRoosterApp.Pages
{
    public class RegisterModel : PageModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Unit { get; set; }

        public string Email { get; set; }

        public void OnGet()
        {
           
        }
    }
}
