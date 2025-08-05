namespace GymSite.Models;

public class Equipment
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public DateTime DateAdded { get; set; }

    public bool InStock { get; set; }
}
