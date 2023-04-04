using day9.Models;

namespace day9.Repo
{
    public interface ICourseRepo
    {
        public List<Course> Index();
        public void Create(Course course);
        public Course Details(int id);

        public void Delete(int id);
        public void Update(int id, Course course);
    }
}
