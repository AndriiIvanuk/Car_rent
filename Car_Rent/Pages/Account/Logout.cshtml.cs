using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Rent.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            // �������� ��� ��� (���-�����)
            HttpContext.Session.Remove("IsLoggedIn");
            HttpContext.Session.Remove("Username");

            return Page();
        }
    }
}
