using System.ComponentModel.DataAnnotations;

namespace day9.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Trainee>? Trainees { get; set; }

    }
}
