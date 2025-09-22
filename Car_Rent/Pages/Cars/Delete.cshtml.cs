using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Rent.Pages.Cars
{
    [Authorize(Roles = "Admin")] //Обмежила доступ для не-адмінів.
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public CarViewModel Car { get; set; } = new();

        public void OnGet(int id)
        {
            // Тимчасово завантажуємо авто (мок-дані)
            //Завантажити авто з БД за id
            // Car = context.Cars.FirstOrDefault(c => c.Id == id);
            Car = new CarViewModel
            {
                Id = id,
                Name = "Toyota Corolla",
                PricePerDay = 40,
                Description = "Приклад авто для видалення"
            };
        }

        public IActionResult OnPost(int id)
        {
            // Тут буде видалення з БД
            // var car = context.Cars.Find(id);
            // context.Cars.Remove(car);
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
