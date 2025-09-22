using System.ComponentModel.DataAnnotations;

namespace Car_Rent.Models
{
    //  ������ ���������
    // ��������������� ���:
    //  - CRUD � ������ 
    //  - ���������� � ��� ����� 
    public class Car
    {
        public int Id { get; set; } // ��������� ����

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // ����� (���������: Toyota)

        [Required]
        [StringLength(100)]
        public string Model { get; set; } // ������ (���������: Corolla)

        [Required]
        [Range(1, 10000)]
        public decimal PricePerDay { get; set; } // ֳ�� �� ���� ������

        [StringLength(500)]
        public string Description { get; set; } // ����

        public bool IsAvailable { get; set; } = true; // ����������

        public string? ImageUrl { get; set; } // ���� (��������� �� ��������)
    }
}


/*
 Id � ���� ��� ��.

[Required], [StringLength], [Range] � �� ��������, ��� ����������� ���� ��������� ��� � ������.

IsAvailable � �� �������� ���� ��� ������.

ImageUrl � ��� ����� ���� �������� ���� �� ���� ������.
 */