using System;
using ChallengePetFriends.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChallengePetFriends.API.Data;

public class PetFriendsContext(DbContextOptions<PetFriendsContext> options) : DbContext(options)
{
    public DbSet<Pet> Pets => Set<Pet>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>().HasData(
            new { Id = 1, Name = "Buddy", Species = "Dog", Age = 3, PhysicalDescription = "Small, brown with white spots", PersonalityDescription = "Friendly and energetic", Price = 250.00M, JoinedDate = DateOnly.Parse("2024-01-15") },
            new { Id = 2, Name = "Mittens", Species = "Cat", Age = 2, PhysicalDescription = "Black with green eyes", PersonalityDescription = "Playful and curious", Price = 150.00M, JoinedDate = DateOnly.Parse("2024-02-20") },
            new { Id = 3, Name = "Charlie", Species = "Parrot", Age = 5, PhysicalDescription = "Green feathers with red tail", PersonalityDescription = "Talkative and social", Price = 300.55M, JoinedDate = DateOnly.Parse("2024-03-13") }
        );
    }
}
