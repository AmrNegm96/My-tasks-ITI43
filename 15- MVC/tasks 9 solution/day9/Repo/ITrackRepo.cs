using day9.Models;

namespace day9.Repo
{
    public interface ITrackRepo
    {
        public List<Track> Index();
        public void Create(Track track);
        public Track Details(int id);
        public void Delete(int id);
        public void Update(int id, Track track);
    }
}
