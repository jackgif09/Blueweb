using Microsoft.EntityFrameworkCore;
using Blueweb.Models;
namespace Blueweb.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
