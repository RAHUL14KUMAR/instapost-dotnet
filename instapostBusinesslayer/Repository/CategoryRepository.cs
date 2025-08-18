using instapostBusinesslayer.Interface.CategoryInterface;
using instapostDataLayer;
using instapostEntitylayer;
using Microsoft.EntityFrameworkCore;

namespace instapostBusinesslayer.Repository
{
    public class CategoryRepository : CategoryIRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CategoryRepository(ApplicationDbContext db)
        {
            dbContext = db;
        }

        public async Task<long> CreateCategory(CategoryEntity ce)
        {
            dbContext.CategoryDb.Add(ce);
            await dbContext.SaveChangesAsync();
            Console.WriteLine("result after adding the category ");
            return ce.id;
        }

        public Task<bool> UpdateCategory(CategoryEntity ce)
        {
            return null;
        }
        public async Task<CategoryEntity> GetCategoryById(long id)
        {
            var res = await dbContext.CategoryDb.Include(p=>p.posts).Include(u=>u.users).FirstOrDefaultAsync(u=>u.id==id);
            Console.WriteLine("getCategoryBy id result "+res);
            return res;
        }
        public async Task<List<CategoryEntity>> GetAllCategory()
        {
            var res = await dbContext.CategoryDb.ToListAsync();
            return res;
        }
    }
}