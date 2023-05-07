using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedLib
{
    public class Trainee
    {
        public int Id { get; set; }
        [Required , StringLength(15 , ErrorMessage ="too long name")]
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        [Required(ErrorMessage ="you must enter email")]
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsGraduated { get; set; }
        public int? TrackId { get; set; }
        public virtual Track? track { get; set; }
    }
    public enum Gender:byte
    {
        Male,Female
    }
}
