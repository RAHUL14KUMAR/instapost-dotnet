using instapostBusinesslayer.Interface.CategoryInterface;
using instapostDataLayer;
using instapostEntitylayer;

namespace instapostBusinesslayer.Repository
{
    public class CategoryRepository : CategoryIRepository
    {
        private ApplicationDbContext dbContext;
        public CategoryRepository(ApplicationDbContext db)
        {
            dbContext = db;
        }

        public Task<long> CreateCategory(CategoryEntity ce)
        {
            return null;
        }

        public Task<bool> UpdateCategory(CategoryEntity ce)
        {
            return null;
        }
        public async Task<CategoryEntity> GetCategoryById(long id)
        {
            var res = await dbContext.CategoryDb.FindAsync(id);
            Console.WriteLine("getCategoryBy id result "+res);
            return res;
        }
        public Task<List<CategoryEntity>> GetAllCategory()
        {
            return null;
        }
    }
}