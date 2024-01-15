using Microsoft.EntityFrameworkCore;
using TodoWebApi.Model;

namespace TodoWebApi.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Todo> Todos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
    }
}
