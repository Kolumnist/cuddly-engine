using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.Models;

namespace WebApplication1.Pages.Calculator
{
    public class CalculatorModel : PageModel
    {
        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("d", new CultureInfo("de-DE"));
            ViewData["TimeStamp"] = dateTime;
            Page();
        }
	}
}
