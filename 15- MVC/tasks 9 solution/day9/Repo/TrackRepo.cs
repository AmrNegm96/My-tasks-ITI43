using day9.Data;
using day9.Models;
using Microsoft.EntityFrameworkCore;

namespace day9.Repo
{
    public class TrackRepo : ITrackRepo
    {
        public readonly ApplicationDbContext Context;
        public TrackRepo(ApplicationDbContext context)
        {
            Context = context;
        }
        public List<Track> Index()
        {
            return Context.Tracks.ToList();
        }
        public void Create(Track track)
        {
            Context.Tracks.Add(track);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            Context.Tracks.Remove(Context.Tracks.Find(id));
            Context.SaveChanges();
        }

        public Track Details(int id)
        {
            var track = Context.Tracks.FirstOrDefault(x => x.Id == id);
            return track;
        }


        public void Update(int id, Track tr)
        {
            Track Updated = Context.Tracks.Find(id);
            Updated.Name = tr.Name;
            Updated.Description = tr.Description;
            Context.SaveChanges();
        }
    }
}
