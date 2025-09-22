using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Car_Rent.Pages.Cars
{
    [Authorize(Roles = "Admin")] //Обмежила доступ для не-адмінів.
    public class IndexModel : PageModel
    {
        // Тимчасові "мок-дані", поки немає бази
        public List<CarViewModel> Cars { get; set; } = new();

        public void OnGet()
        {
            Cars = new List<CarViewModel>
            {
                new CarViewModel { Id = 1, Name = "Tesla Model S", PricePerDay = 120, Description = "Електрокар, запас ходу 600 км" },
                new CarViewModel { Id = 2, Name = "BMW X5", PricePerDay = 90, Description = "Позашляховик преміум-класу" },
                new CarViewModel { Id = 3, Name = "Toyota Corolla", PricePerDay = 40, Description = "Надійний седан для міста" }
            };
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
