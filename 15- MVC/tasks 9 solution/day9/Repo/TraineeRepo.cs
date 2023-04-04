using day9.Data;
using day9.Models;
using Microsoft.EntityFrameworkCore;

namespace day9.Repo
{
    public class TraineeRepo : ITraineeRepo
    {
        public readonly ApplicationDbContext Context;
        public TraineeRepo(ApplicationDbContext context)
        {
            Context = context;
        }

        public void Create(Trainee trinee)
        {
            Context.Trainees.Add(trinee);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            Context.Trainees.Remove(Context.Trainees.Find(id));
            Context.SaveChanges();  
        }

        public Trainee Details(int id)
        {
            var trainee = Context.Trainees.FirstOrDefault(x => x.Id == id);
            return trainee;
        }

        public List<Trainee> Index()
        {
            return Context.Trainees.ToList();
        }

        public void Update(int id, Trainee tr)
        {
            Trainee Updated = Context.Trainees.Find(id);
            Updated.Name = tr.Name;
            Updated.Email = tr.Email;
            Updated.Birthdate = tr.Birthdate;
            Updated.Gender =   tr.Gender;
            Updated.PhoneNumber = tr.PhoneNumber;
            Context.SaveChanges();
        }
    }
}
