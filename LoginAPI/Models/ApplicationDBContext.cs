using Microsoft.EntityFrameworkCore;

namespace LoginAPI.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
        }

        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
