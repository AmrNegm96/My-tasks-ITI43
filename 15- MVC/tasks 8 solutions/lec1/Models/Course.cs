using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace lec1.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CourseGrade { get; set; }

        [Required]
        public string Topic { get; set; }
        

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
