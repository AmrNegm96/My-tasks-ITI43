using day9.Models;

namespace day9.Repo
{
    public interface ITraineeRepo
    {
        public List<Trainee> Index();
        public void Create(Trainee trinee);
        public Trainee Details(int id);

        public void Delete(int id);
        public void Update(int id , Trainee trinee);
    }
}
