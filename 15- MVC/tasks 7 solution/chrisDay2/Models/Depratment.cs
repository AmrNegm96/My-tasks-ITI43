using System.Collections.Generic;

namespace chrisDay2.Models
{
    public class Depratment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public List<Student> Student { get; set; }
    }
}