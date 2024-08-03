using ASPContacts.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPContacts.Data
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
