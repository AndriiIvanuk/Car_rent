using System.ComponentModel.DataAnnotations;

namespace Car_Rent.Models
{
    //  Модель автомобіля
    // Використовується для:
    //  - CRUD в адмінці 
    //  - Збереження в базі даних 
    public class Car
    {
        public int Id { get; set; } // Первинний ключ

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // Назва (наприклад: Toyota)

        [Required]
        [StringLength(100)]
        public string Model { get; set; } // Модель (наприклад: Corolla)

        [Required]
        [Range(1, 10000)]
        public decimal PricePerDay { get; set; } // Ціна за день оренди

        [StringLength(500)]
        public string Description { get; set; } // Опис

        public bool IsAvailable { get; set; } = true; // Доступність

        public string? ImageUrl { get; set; } // Фото (посилання на картинку)
    }
}


/*
 Id — ключ для БД.

[Required], [StringLength], [Range] — це валідація, яка автоматично буде перевіряти дані у формах.

IsAvailable — чи доступне авто для оренди.

ImageUrl — тут можна буде зберігати шлях до фото машини.
 */