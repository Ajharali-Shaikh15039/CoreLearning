using Microsoft.EntityFrameworkCore;

namespace FreeOurSelf.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<StudentModel> Students { get; set; }




    
    }
}
