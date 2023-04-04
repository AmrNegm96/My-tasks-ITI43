using System.ComponentModel.DataAnnotations.Schema;

namespace chrisDay2.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public string Image { get; set; }

        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DepratmentId { get; set; }
        public Depratment Depratment { get; set; }
    }
}
