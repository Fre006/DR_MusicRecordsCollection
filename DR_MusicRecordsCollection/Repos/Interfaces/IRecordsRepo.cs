using DR_MusicRecordsCollection.Models;

namespace DR_MusicRecordsCollection.Repos.Interfaces
{
    public interface IRecordsRepo
    {
        public IEnumerable<Record> GetAll();
        public IEnumerable<Record> GetByTitle(string title);
        public IEnumerable<Record> GetByArtist(string artist);
        public IEnumerable<Record> GetByPublicationYear(int pubYear);
    }
}
