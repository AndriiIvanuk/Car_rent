using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Rent.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // ��������� �������� (���-����)
            if (Username == "admin" && Password == "123")
            {
                Message = "������� ����!";
                return RedirectToPage("/Index");
            }

            Message = "������� ���� ��� ������.";
            return Page();
        }
    }
}
