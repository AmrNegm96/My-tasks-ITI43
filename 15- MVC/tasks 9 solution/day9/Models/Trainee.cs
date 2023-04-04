using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day9.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }

        public List<Course> Courses { get; set; }

        [ForeignKey("Track")]
        public int TrackID { get; set; }
        public Track Track { get; set; }
    }
}
