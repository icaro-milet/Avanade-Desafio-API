using Avanade.Challenge.Domain;
using Avanade.Challenge.Infra.InitializeDB;
using Microsoft.EntityFrameworkCore;

namespace Avanade.Challenge.Infra.Context
{
    public class ChallengeDB : DbContext
    {
        public ChallengeDB(DbContextOptions<ChallengeDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.InitDb();
        }

        public DbSet<Person> People { get; set; }
    }
}
