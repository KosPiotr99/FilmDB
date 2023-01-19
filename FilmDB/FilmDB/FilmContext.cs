using FilmDB.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDB
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = @"Data Source=NT-27.WWSI.EDU.PL,1601;Initial Catalog=KASETY_502_10;User ID=Z502_10;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(cs);
        }
    }
}
