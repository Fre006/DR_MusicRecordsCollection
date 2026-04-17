using DR_MusicRecordsCollection.Repos;
using DR_MusicRecordsCollection.Repos.Interfaces;
using DR_MusicRecordsCollection.DBContexts;
using DR_MusicRecordsCollection.Models;
using Microsoft.IdentityModel.Tokens;
namespace DR_MusicRecordsCollection_Test.RepositoryTests
{
    public class RecordsRepoTests
    {
        private IRecordsRepo _recordsRepo;

        public RecordsRepoTests(RecordsDBContext context)
        {
            _recordsRepo = new RecordsRepo();
        }
        [Fact]
        public void GetAllTest()
        {
            if (_recordsRepo != null)
            {
                List<DR_MusicRecordsCollection.Models.Record> TestRecords = (List<DR_MusicRecordsCollection.Models.Record>)_recordsRepo.GetAll();
                Assert.True(TestRecords[0].Title == "Bohemian Rhapsody");
                Assert.True(TestRecords[0].Artist == "Queen");
                Assert.True(TestRecords[0].Duration == 354);
                Assert.True(TestRecords[0].PublicationYear == 1975);

            }
        }
    }
}
