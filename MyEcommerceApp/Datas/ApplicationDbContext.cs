using Microsoft.EntityFrameworkCore;

namespace MyEcommerceApp.Datas
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
    }
}
