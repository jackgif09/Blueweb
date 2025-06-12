using Microsoft.EntityFrameworkCore;
using Blueweb.Models;
using Blueweb.Models.Blueweb.Models;
namespace Blueweb.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
    }
}
