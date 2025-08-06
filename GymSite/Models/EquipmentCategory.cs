using System.ComponentModel.DataAnnotations;

namespace GymSite.Models;

public class EquipmentCategory
{
    [Key]
    public int Id { get; set; }

    public string Category { get; set; } = string.Empty;

    public ICollection<Equipment> EquipmentList { get; set; }
}
