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

        public RecordsRepoTests()
        {
            _recordsRepo = new RecordsRepo();
        }
        [Fact]
        public void GetAllTest()
        {
            if (_recordsRepo != null)
            {
                IEnumerable<DR_MusicRecordsCollection.Models.Record> TestRecords = (IEnumerable<DR_MusicRecordsCollection.Models.Record>)_recordsRepo.GetAll();
                var testRecordsList = TestRecords.ToList<DR_MusicRecordsCollection.Models.Record>();
                DR_MusicRecordsCollection.Models.Record Queen = new DR_MusicRecordsCollection.Models.Record { ID = 1, Title = "Bohemian Rhapsody", Artist = "Queen", Duration = 354, PublicationYear = 1975 };
                Assert.True(testRecordsList[0].Title == "Bohemian Rhapsody");
                Assert.True(testRecordsList[0].Artist == "Queen");
                Assert.True(testRecordsList[0].Duration == 354);
                Assert.True(testRecordsList[0].PublicationYear == 1975);
                Assert.True(testRecordsList.Count >= 3);

            }
        }
    }
}
