using ChallengePetFriends.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPetsEndpoints();

app.Run();
