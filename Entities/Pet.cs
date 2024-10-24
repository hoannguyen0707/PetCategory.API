using System;

namespace ChallengePetFriends.API.Entities;

public class Pet
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Species { get; set; }
    public int Age { get; set; }
    public string? PhysicalDescription { get; set; }
    public string? PersonalityDescription { get; set; }
    public Decimal Price { get; set; }
    public DateOnly JoinedDate { get; set; }

}
