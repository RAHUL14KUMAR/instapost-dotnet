using instapostEntitylayer;
using Microsoft.EntityFrameworkCore;
namespace instapostDataLayer;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<UserEntity> UsersDb { get; set; }
    public DbSet<CategoryEntity> CategoryDb { get; set; }
    public DbSet<PostEntity> PostDb{ get; set; }
}