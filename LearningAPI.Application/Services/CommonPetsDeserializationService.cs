using LearningAPI.Application.Interfaces;
using LearningAPI.Entities.Models;

namespace LearningAPI.Application.Services
{
    public class CommonPetsDeserializationService : ICommonPetsDeserializationService
    {
        public static CommonPets DeserializeCommonPets()
        {
            string fileName = @"LearningAPI.JSON\CommonPets.json";
            string jsonString = File.ReadAllText(fileName);
            List<PetDetails> commonPets = JsonSerializer.Deserialize<PetDetails>(jsonString);

            return commonPets;
        }
    }
}