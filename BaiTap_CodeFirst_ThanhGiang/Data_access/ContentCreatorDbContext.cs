using BaiTap_CodeFirst_ThanhGiang.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTap_CodeFirst_ThanhGiang.Data_access
{
    public class ContentCreatorDbContext : DbContext
    {
        public ContentCreatorDbContext(DbContextOptions<ContentCreatorDbContext> options) : base(options) {
        }
        public DbSet<ContentCreator> contentCreators { get; set; }
        public DbSet<Video> video { get; set; }
    }
}
