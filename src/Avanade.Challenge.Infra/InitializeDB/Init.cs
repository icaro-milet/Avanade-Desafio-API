using Avanade.Challenge.Domain;
using Microsoft.EntityFrameworkCore;

namespace Avanade.Challenge.Infra.InitializeDB
{
    public static class Init
    {
        public static void InitDb(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id = 1,
                    Name = "Levi",
                    Salary = 1000000000000,
                    Active = true
                }
            );
        }
    }
}
