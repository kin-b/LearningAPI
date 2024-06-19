namespace LearningAPI.Entities.Models
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
}
