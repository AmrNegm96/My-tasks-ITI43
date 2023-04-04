namespace day_2_ch.Models
{
    public class Depratment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public List<Student> Student { get; set; }
    }
}