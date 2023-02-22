using Microsoft.EntityFrameworkCore;
using Simple_WebApp.Models;

namespace Simple_WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Todo> Todos { get; set; }
    }
}
