using instapostBusinesslayer.ViewModels;

namespace instapostBusinesslayer.Service.Interface
{
    public interface CategorySInterface
    {
        Task<long> CreateCategory(CategoryModel ce);
        Task<bool> UpdateCategory(CategoryModel ce);

        Task<CategoryModel> GetCategoryById(long id);

        Task<List<CategoryModel>> GetAllCategory();
    }
}