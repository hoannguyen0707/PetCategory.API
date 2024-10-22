namespace ChallengePetFriends.API.Dtos;

public record class PetsDto
(
    int Id,
    string Name,
    string Species,
    int Age,
    string PhysicalDescription,
    string PersonalityDescription,
    decimal Price,
    DateOnly JoinedDate
);
