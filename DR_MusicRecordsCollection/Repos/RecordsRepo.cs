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
    }
}
