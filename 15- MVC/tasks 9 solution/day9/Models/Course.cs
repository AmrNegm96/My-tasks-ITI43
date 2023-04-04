using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace day9.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string? Topic { get; set; }
        [Range(minimum: 0, maximum: 10)]
        public int? Grade { get; set; }

        [ForeignKey("Trainee")]
        public int? TraineeID { get; set; }
        public Trainee? Trainee { get; set; }

        
    }
}
