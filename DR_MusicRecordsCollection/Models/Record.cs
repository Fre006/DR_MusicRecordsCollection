namespace DR_MusicRecordsCollection.Models
{
    public class Record
    {
        public string? Title {  get; set; }
        public string? Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public Record()
        {
            Title = null;
            Artist = null;
            Duration = 0;
            PublicationYear = 0;
        }

        public Record(string title, string artist, int duration, int publicationYear)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }
    }
}
