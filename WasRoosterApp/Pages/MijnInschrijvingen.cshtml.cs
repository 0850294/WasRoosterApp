using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WasRoosterApp.Pages
{
    public class MijnInschrijvingenModel : PageModel
    {
        public string Machine { get; set; }

        public string Datum { get; set; }

        public string Tijd { get; set; }

        public void OnGet()
        {
            Machine = "Wasmachine 1";
            Datum = "28/6/2019";
            Tijd = "10.30-12.00";
        }
    }
}
