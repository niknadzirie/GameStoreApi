using FluentValidation.AspNetCore;
using FluentValidation;
using GameStore.Api.Dtos;
using GameStore.Api.Endpoints;
using GameStore.Api.Data;
using GameStore.Api.Models;

var builder = WebApplication.CreateBuilder(args);

//.NET 10
builder.Services.AddValidation();

//Prior .NET Version
builder.Services.AddValidatorsFromAssemblyContaining<CreateGameDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateGameDtoValidator>();

builder.AddGameStoreDb();

var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

app.MigrateDb();

app.Run();
