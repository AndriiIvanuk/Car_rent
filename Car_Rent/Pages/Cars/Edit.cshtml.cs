using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Rent.Pages.Cars
{
    [Authorize(Roles = "Admin")] //�������� ������ ��� ��-�����.
    public class EditModel : PageModel
    {
        [BindProperty]
        public CarViewModel Car { get; set; } = new();

        public void OnGet(int id)
        {
            // ��������� ������ ���� �� id (���-���)
            //����������� ���� � �� �� id
            // Car = context.Cars.FirstOrDefault(c => c.Id == id);
            Car = new CarViewModel
            {
                Id = id,
                Name = "BMW X5",
                PricePerDay = 90,
                Description = "������� ���� ��� �����������"
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // ��� ���� ��������� � ��
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
