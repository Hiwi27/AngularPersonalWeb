using Microsoft.EntityFrameworkCore;
using PersonalWebTest.Models.Domain;

namespace PersonalWebTest.Data
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
