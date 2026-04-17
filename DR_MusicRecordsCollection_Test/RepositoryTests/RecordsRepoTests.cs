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
                IEnumerable<DR_MusicRecordsCollection.Models.Record> TestRecords = _recordsRepo.GetAll();
                var testRecordsList = TestRecords.ToList();
                DR_MusicRecordsCollection.Models.Record Queen = new DR_MusicRecordsCollection.Models.Record { ID = 1, Title = "Bohemian Rhapsody", Artist = "Queen", Duration = 354, PublicationYear = 1975 };
                Assert.True(testRecordsList[0].Title == "Bohemian Rhapsody");
                Assert.True(testRecordsList[0].Artist == "Queen");
                Assert.True(testRecordsList[0].Duration == 354);
                Assert.True(testRecordsList[0].PublicationYear == 1975);
                Assert.True(testRecordsList.Count >= 3);
            }
        }

        [Fact]
        public void GetByTests()
        {
            if (_recordsRepo != null)
            {
                IEnumerable<DR_MusicRecordsCollection.Models.Record> TestRecords = _recordsRepo.GetByTitle("Smells Like Teen Spirit");
                var testRecordsList = TestRecords.ToList();
                Assert.True(testRecordsList[0].Title == "Smells Like Teen Spirit");
                Assert.True(testRecordsList[0].Artist == "Nirvana");
                Assert.True(testRecordsList[0].Duration == 301);
                Assert.True(testRecordsList[0].PublicationYear == 1991);

                TestRecords = _recordsRepo.GetByArtist("Michael Jackson");
                testRecordsList = TestRecords.ToList();

                Assert.True(testRecordsList[0].Title == "Billie Jean");
                Assert.True(testRecordsList[0].Artist == "Michael Jackson");
                Assert.True(testRecordsList[0].Duration == 294);
                Assert.True(testRecordsList[0].PublicationYear == 1982);

                TestRecords = _recordsRepo.GetByPublicationYear(2019);
                testRecordsList = TestRecords.ToList();

                Assert.True(testRecordsList[0].Title == "Blinding Lights");
                Assert.True(testRecordsList[0].Artist == "The Weeknd");
                Assert.True(testRecordsList[0].Duration == 200);
                Assert.True(testRecordsList[0].PublicationYear == 2019);
            }
        }
    }
}
