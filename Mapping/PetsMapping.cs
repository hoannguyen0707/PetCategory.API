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

    public static Pet ToEntity(this CreatePetDto pet)
    {
        return new Pet()
        {
            Name = pet.Name,
            Species = pet.Species,
            Age = pet.Age,
            PhysicalDescription = pet.PhysicalDescription,
            PersonalityDescription = pet.PersonalityDescription,
            Price = pet.Price,
            JoinedDate = pet.JoinedDate
        };
    }

    public static Pet ToEntity(this UpdatePetDto pet, int id)
    {
        return new Pet()
        {
            Id = id,
            Name = pet.Name,
            Species = pet.Species,
            Age = pet.Age,
            PhysicalDescription = pet.PhysicalDescription,
            PersonalityDescription = pet.PersonalityDescription,
            Price = pet.Price,
            JoinedDate = pet.JoinedDate
        };
    }
}
