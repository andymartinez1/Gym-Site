using GymSite.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSite.Data;

public static class SeedCategoryData
{
    public static void InitializeCategories(IServiceProvider serviceProvider)
    {
        using var context = new GymDBContext(
            serviceProvider.GetRequiredService<DbContextOptions<GymDBContext>>()
        );

        if (context.EquipmentCategories.Any())
            return;

        context.EquipmentCategories.AddRange(
            new EquipmentCategory { Category = "Cardio" },
            new EquipmentCategory { Category = "Power Lifting" },
            new EquipmentCategory { Category = "Strength Training" },
            new EquipmentCategory { Category = "Functional Training" }
        );

        context.SaveChanges();
    }
}
