using GymSite.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSite.Data;

public class GymDBContext : DbContext
{
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<EquipmentCategory> EquipmentCategories { get; set; }

    public GymDBContext(DbContextOptions<GymDBContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<EquipmentCategory>()
            .HasMany(c => c.EquipmentList)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.EquipmentCategoryId)
            .HasPrincipalKey(c => c.Id)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}
