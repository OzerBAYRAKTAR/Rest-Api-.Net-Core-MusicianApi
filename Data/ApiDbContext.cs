using Microsoft.EntityFrameworkCore;
using MusicApi.Models;

namespace MusicApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {
            
        }
        public DbSet<Song> Songs { get; set; }  // DbContext will create a table as a name with Songs
        public DbSet<Artist> Artists { get; set; }  // DbContext will create a table as a name with Artists
        public DbSet<Album> Albums { get; set; }  // DbContext will create a table as a name with Albums




    }

}
