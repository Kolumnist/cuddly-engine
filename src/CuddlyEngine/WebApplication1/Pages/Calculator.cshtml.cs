using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace WebApplication1.Pages
{
    public class CalculatorModel : PageModel
    {
        int result = 0;

        public void OnGet()
        {
			string dateTime = DateTime.Now.ToString("d", new CultureInfo("de-DE"));
			ViewData["TimeStamp"] = dateTime;
		}
    }
}
