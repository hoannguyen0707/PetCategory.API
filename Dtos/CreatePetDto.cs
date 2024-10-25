using System.ComponentModel.DataAnnotations;

namespace ChallengePetFriends.API.Dtos;

public record class CreatePetDto(
    [Required][StringLength(50)] string Name,
    [Required][StringLength(50)] string Species,
    int Age,
    [StringLength(250)] string? PhysicalDescription,
    [StringLength(250)] string? PersonalityDescription,
    decimal Price,
    DateOnly JoinedDate
);
