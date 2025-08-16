using instapostEntitylayer;
using Microsoft.EntityFrameworkCore;
namespace instapostDataLayer;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<UserEntity> usersDb { get; set; }
    public DbSet<CategoryEntity> categoryDb { get; set; }
    public DbSet<PostEntity> postDb{ get; set; }
}