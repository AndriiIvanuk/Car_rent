using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Rent.Pages.Cars
{
    [Authorize(Roles = "Admin")] //Обмежила доступ для не-адмінів.
    public class EditModel : PageModel
    {
        [BindProperty]
        public CarViewModel Car { get; set; } = new();

        public void OnGet(int id)
        {
            // Тимчасово шукаємо авто по id (мок-дані)
            //Завантажити авто з БД за id
            // Car = context.Cars.FirstOrDefault(c => c.Id == id);
            Car = new CarViewModel
            {
                Id = id,
                Name = "BMW X5",
                PricePerDay = 90,
                Description = "Приклад авто для редагування"
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Тут буде оновлення в БД
            // context.Update(Car);
            // context.SaveChanges();
            return RedirectToPage("Index");
        }

        public class CarViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public decimal PricePerDay { get; set; }
            public string Description { get; set; } = string.Empty;
        }
    }
}
