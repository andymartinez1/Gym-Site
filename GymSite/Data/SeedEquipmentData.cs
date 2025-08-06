using GymSite.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSite.Data;

public static class SeedEquipmentData
{
    public static void InitializeEquipment(IServiceProvider serviceProvider)
    {
        using var context = new GymDBContext(
            serviceProvider.GetRequiredService<DbContextOptions<GymDBContext>>()
        );

        if (context.Equipments.Any())
            return;

        context.Equipments.AddRange(
            new Equipment
            {
                Name = "Treadmill",
                Description = "Treadmill",
                Quantity = 4,
                DateAdded = DateOnly.Parse("2025-07-31"),
                InMaintenance = false,
                EquipmentCategoryId = 1,
            },
            new Equipment
            {
                Name = "Stationary Bike",
                Description = "Stationary Bicycle",
                Quantity = 3,
                DateAdded = DateOnly.Parse("2025-07-29"),
                InMaintenance = false,
                EquipmentCategoryId = 1,
            },
            new Equipment
            {
                Name = "Stationary Bike",
                Description = "Stationary Bicycle",
                Quantity = 3,
                DateAdded = DateOnly.Parse("2025-07-29"),
                InMaintenance = false,
                EquipmentCategoryId = 1,
            },
            new Equipment
            {
                Name = "Squat Rack",
                Description = "2,000 lb capacity rack",
                Quantity = 2,
                DateAdded = DateOnly.Parse("2025-07-25"),
                InMaintenance = false,
                EquipmentCategoryId = 2,
            },
            new Equipment
            {
                Name = "Incline Bench",
                Description = "800 lb capacity bench with rack",
                Quantity = 2,
                DateAdded = DateOnly.Parse("2025-07-27"),
                InMaintenance = false,
                EquipmentCategoryId = 2,
            },
            new Equipment
            {
                Name = "Deadlift Platform",
                Description = "Platform for deadlifting",
                Quantity = 3,
                DateAdded = DateOnly.Parse("2025-07-29"),
                InMaintenance = false,
                EquipmentCategoryId = 2,
            },
            new Equipment
            {
                Name = "Lat Pulldown Machine",
                Description = "Machine for doing lat pulldowns",
                Quantity = 2,
                DateAdded = DateOnly.Parse("2025-07-29"),
                InMaintenance = false,
                EquipmentCategoryId = 3,
            },
            new Equipment
            {
                Name = "Smith Machine",
                Description = "Multi use Smith Machine",
                Quantity = 2,
                DateAdded = DateOnly.Parse("2025-07-29"),
                InMaintenance = false,
                EquipmentCategoryId = 3,
            },
            new Equipment
            {
                Name = "Kettlebell",
                Description = "Kettlebell",
                Quantity = 4,
                DateAdded = DateOnly.Parse("2025-08-01"),
                InMaintenance = false,
                EquipmentCategoryId = 4,
            }
        );

        context.SaveChanges();
    }
}
