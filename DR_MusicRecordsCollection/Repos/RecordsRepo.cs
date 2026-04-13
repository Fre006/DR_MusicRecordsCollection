using DR_MusicRecordsCollection.Models;
using DR_MusicRecordsCollection.DBContexts;
using DR_MusicRecordsCollection.Repos.Interfaces;
namespace DR_MusicRecordsCollection.Repos
{
    public class RecordsRepo: IRecordsRepo
    {
        private readonly RecordsDBContext _dbContext;
        public RecordsRepo(RecordsDBContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<Record> GetAll()
        {

            return _dbContext.Records;
        }
    }
}
