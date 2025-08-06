using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymSite.Models;

public class EquipmentViewModel
{
    public Equipment Equipment { get; set; }

    public List<Equipment> EquipmentList { get; set; }

    public EquipmentCategory EquipmentCategory { get; set; }

    public SelectList? Category { get; set; }

    public string SearchString { get; set; } = string.Empty;
}
