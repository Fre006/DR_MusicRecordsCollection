using Microsoft.EntityFrameworkCore;
using DR_MusicRecordsCollection.Repos;
using DR_MusicRecordsCollection.Models;

namespace DR_MusicRecordsCollection.DBContexts
{
    public class RecordsDBContext : DbContext
    {
        public RecordsDBContext(DbContextOptions<RecordsDBContext> options) : base(options)
        {
        }
        public DbSet<Record> Records { get; set; }
    }
}
