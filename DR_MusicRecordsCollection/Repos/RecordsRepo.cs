using DR_MusicRecordsCollection.DBContexts;
using DR_MusicRecordsCollection.Models;
using DR_MusicRecordsCollection.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace DR_MusicRecordsCollection.Repos
{
    public class RecordsRepo: IRecordsRepo
    {
        private readonly RecordsDBContext _dbContext;
        public RecordsRepo()
        {
            var optionsBuilder = new DbContextOptionsBuilder<RecordsDBContext>();
            optionsBuilder.UseSqlServer(Secrets.Secrets.ConnectionString);
            _dbContext = new RecordsDBContext(optionsBuilder.Options);
        }

        public IEnumerable<Record> GetAll()
        {
            return _dbContext.Records;
        }

        public IEnumerable<Record> GetByTitle(string title)
        {
            return _dbContext.Records.Where(x => x.Title == title);
        }
        public IEnumerable<Record> GetByArtist(string artist)
        {
            return _dbContext.Records.Where(x => x.Artist == artist);
        }
        public IEnumerable<Record> GetByPublicationYear(int pubYear)
        {
            return _dbContext.Records.Where(x => x.PublicationYear == pubYear);
        }
    }
}
