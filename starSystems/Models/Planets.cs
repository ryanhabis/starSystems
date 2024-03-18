using System.ComponentModel.DataAnnotations;

namespace starSystems.Models
{
    public class Planets
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int StarId { get; set; }
        public string? StarSystem { get; set; }
    }
}
