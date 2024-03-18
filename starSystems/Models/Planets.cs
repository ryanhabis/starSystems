using System.ComponentModel.DataAnnotations;

namespace starSystems.Models
{
    public class Planets
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }

        public int StarId { get; set; }
        [MaxLength(500)]
        public string StarSystem { get; set; }
    }
}
