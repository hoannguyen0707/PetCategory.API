using System;
using ChallengePetFriends.API.Dtos;
using ChallengePetFriends.API.Entities;

namespace ChallengePetFriends.API.Mapping;

public static class PetsMapping
{
    public static PetsDto ToDto(this Pet pet)
    {
        return new(
            pet.Id,
            pet.Name,
            pet.Species,
            pet.Age,
            pet.PhysicalDescription,
            pet.PersonalityDescription,
            pet.Price,
            pet.JoinedDate
        );
    }
}
