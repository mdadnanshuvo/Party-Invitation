using Microsoft.EntityFrameworkCore;
using PartyInvites.Models;

namespace PartyInvites.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<GuestRespond> guestsInvitation { get; set; }
    }
}
