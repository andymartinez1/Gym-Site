using System.ComponentModel.DataAnnotations;

namespace GymSite.Models;

public class Equipment
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public DateOnly DateAdded { get; set; }

    public bool InMaintenance { get; set; }

    public int EquipmentCategoryId { get; set; }

    [Required]
    public EquipmentCategory Category { get; set; }
}
