using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lec1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public List<Course> Courses { get; set; }
    }
}
