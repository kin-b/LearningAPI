using System.Text.Json;
using LearningAPI.Application.Interfaces;
using LearningAPI.Entities.Models;


namespace LearningAPI.Application.Services
{
    public class CommonPetsDeserializationService : ICommonPetsDeserializationService
    {
        public CommonPets? DeserializeCommonPets()
        {
            string fileName = @"LearningAPI.JSON\CommonPets.json";
            string jsonString = File.ReadAllText(fileName);
            CommonPets? commonPets = JsonSerializer.Deserialize<CommonPets>(jsonString);
            return commonPets;
        }
    }
}