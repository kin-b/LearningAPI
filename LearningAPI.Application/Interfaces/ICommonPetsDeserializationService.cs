using LearningAPI.Entities.Models;

namespace LearningAPI.Application.Interfaces
{
    public interface ICommonPetsDeserializationService
    {
        CommonPets? DeserializeCommonPets();        
    }
}
