using ChallengePetFriends.API.Data;
using ChallengePetFriends.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("PetStore");
builder.Services.AddSqlite<PetFriendsContext>(connString);


var app = builder.Build();

app.MapPetsEndpoints();
app.MigrateDbAsync();

app.Run();
