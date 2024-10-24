using System;
using Microsoft.EntityFrameworkCore;

namespace ChallengePetFriends.API.Data;

public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<PetFriendsContext>();
        dbContext.Database.Migrate();
    }

}
