using LearningAPI.LearningAPI.JSON;


var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();


app.MapGet("/CommonPets", CommonPetsDeserialization.DeserializeCommonPets);
app.MapGet("/PleaseWork", () => "Please Work");

app.Run();
