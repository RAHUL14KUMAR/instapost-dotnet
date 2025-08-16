using instapostEntitylayer;

namespace instapostBusinesslayer.Interface.CategoryInterface
{
    public interface CategoryIRepository
    {
        Task<long> CreateCategory(CategoryEntity ce);
        Task<bool> UpdateCategory(CategoryEntity ce);

        Task<CategoryEntity> GetCategoryById(long id);

        Task<List<CategoryEntity>> GetAllCategory();
    }
}