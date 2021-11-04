using Microsoft.EntityFrameworkCore;

namespace EfCoreExample_DataAccess.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        
        
    }
}