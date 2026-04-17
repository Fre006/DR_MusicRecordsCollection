using DR_MusicRecordsCollection.Models;

namespace DR_MusicRecordsCollection.Repos.Interfaces
{
    public interface IRecordsRepo
    {
        public IEnumerable<Record> GetAll();
    }
}
