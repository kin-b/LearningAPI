//using LearningAPI.LearningAPI.JSON;
using LearningAPI.Entities;
using LearningAPI.Application.Services;
using LearningAPI.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

ICommonPetsDeserializationService commonPetsResponseJson = new CommonPetsDeserializationService();

app.MapGet("/CommonPets", commonPetsResponseJson.DeserializeCommonPets);

//app.MapGet("/CommonPets", CommonPetsDeserialization.DeserializeCommonPets);
//app.MapGet("/PleaseWork", () => "Please Work");

app.Run();
