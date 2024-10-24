using System;
using ChallengePetFriends.API.Data;
using ChallengePetFriends.API.Dtos;
using ChallengePetFriends.API.Entities;
using ChallengePetFriends.API.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ChallengePetFriends.API.Endpoints;

public static class PetsEndpoints
{
    // private static readonly List<PetsDto> pets = [
    //     new (
    //     1,
    //     "Lola",
    //     "dog",
    //     2,
    //     "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
    //     "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.",
    //     22.99M,
    //     new DateOnly(2023,7,15)),
    // new (
    //     1,
    //     "Loki",
    //     "dog",
    //     9,
    //     "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.",
    //     "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.",
    //     32.55M,
    //     new DateOnly(2023,7,01)),
    // new (
    //     3,
    //     "Lucy",
    //     "Cat",
    //     5,
    //     "medium grey male weighing about 13 pounds",
    //     "Friendly, high energy.",
    //     23.55M,
    //     new DateOnly(2023,7,01)),
    // new (
    //     4,
    //     "Puss",
    //     "Cat",
    //     6,
    //     "small white female weighing about 8 pounds. litter box trained.",
    //     "Friendly",
    //     40.55M,
    //     new DateOnly(2022,2,18))
    // ];

    const string GetPetEndPointName = "GetPet";

    public static RouteGroupBuilder MapPetsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("pets").WithParameterValidation();

        //GET /pets
        group.MapGet("/", (PetFriendsContext dbContext) =>
                dbContext.Pets
                    .Select(pet => pet.ToDto())
                    .AsNoTracking());

        //GET /pets/1
        group.MapGet("/{id}", (int id, PetFriendsContext dbContext) =>
        {
            Pet? pet = dbContext.Pets.Find(id);
            return pet is null ?
                    Results.NotFound() : Results.Ok(pet.ToDto());
        }).WithName(GetPetEndPointName);

        return group;
    }

}
