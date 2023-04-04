using day9.Data;
using day9.Models;

namespace day9.Repo
{
    public class CourseRepo : ICourseRepo
    {

        public ApplicationDbContext Context { get; }

        public CourseRepo(ApplicationDbContext context)
        {
            Context = context;
        }
        public void Create(Course course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            Context.Courses.Remove(Context.Courses.Find(id));
            Context.SaveChanges();
        }

        public Course Details(int id)
        {
            return Context.Courses.Find(id);
        }

        public List<Course> Index()
        {
            return Context.Courses.ToList();
        }

        public void Update(int id, Course course)
        {
            Course TrUpdated = Context.Courses.Find(id);

            TrUpdated.Topic = course.Topic;
            TrUpdated.Grade = course.Grade;

            Context.SaveChanges();
        }
    }
}
