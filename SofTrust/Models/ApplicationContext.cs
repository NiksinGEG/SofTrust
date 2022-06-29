using Microsoft.EntityFrameworkCore;

namespace SofTrust.Models
{
        public class ApplicationContext : DbContext
        {
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Message> Messages { get; set; }
            public DbSet<Dictionary> Dictionaries { get; set; }

            public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
                //Database.EnsureDeleted();
                Database.EnsureCreated();
            }
          /*
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-ONP6D98;Database=SofTrust;Trusted_Connection=True;");
            }*/

            
        }
}
