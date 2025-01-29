using Microsoft.EntityFrameworkCore;
using PersonalWebTest.Models.Domain;

namespace PersonalWebTest.Data
{
    public class PersonalWebDbContext : DbContext
    {
        public PersonalWebDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
