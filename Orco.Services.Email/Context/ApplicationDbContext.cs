using Microsoft.EntityFrameworkCore;
using Orco.Services.Email.Models;

namespace Orco.Services.Email.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<EmailLog> EmailLogs { get; set; }
    }
}
