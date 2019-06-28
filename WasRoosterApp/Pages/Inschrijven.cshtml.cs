using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WasRoosterApp.Pages
{
    public class InschrijvenModel : PageModel
    {
        public string Wasmachine1 { get; set; }

        public string Wasmachine2 { get; set; }

        public string Wasmachine3 { get; set; }

        public string Droger1 { get; set; }

        public string Droger2 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime Datum { get; set; }

        public string Tijd { get; set; }

        public void OnGet()
        {
            Datum = DateTime.Now;
        }
    }
}
