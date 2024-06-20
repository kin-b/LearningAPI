using System.Text.Json;

namespace LearningAPI.LearningAPI.JSON
{
    public class CommonPets
    {
        public List<PetDetails>? Pets { get; set; }

    }
    public class PetDetails
    {
        public string? animal { get; set; }
        public string? type { get; set; }
        public string? size { get; set; }
        public bool? needsSpecialHabitat { get; set; }
        public string? habitatType { get; set; }
    }

    public class CommonPetsDeserializationOld
    {
        public static CommonPets DeserializeCommonPets()
        {
            string fileName = @"LearningAPI.JSON\CommonPets.json";
            string jsonString = File.ReadAllText(fileName);
            CommonPets commonPets = JsonSerializer.Deserialize<CommonPets>(jsonString)!;
            
            return commonPets;
        }
    }

}
