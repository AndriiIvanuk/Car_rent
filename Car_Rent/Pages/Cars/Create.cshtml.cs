using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Rent.Pages.Cars
{
    [Authorize(Roles = "Admin")] //Обмежила доступ для не-адмінів.
    public class CreateModel : PageModel
    {
        [BindProperty]
        public CarViewModel Car { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Тут буде збереження в БД
            // context.Cars.Add(Car);
            // context.SaveChanges();
            // Поки просто редірект на список
            return RedirectToPage("Index");
        }

        public class CarViewModel
        {
            public string Name { get; set; } = string.Empty;
            public decimal PricePerDay { get; set; }
            public string Description { get; set; } = string.Empty;
        }
    }
}
