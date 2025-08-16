using System.Runtime.CompilerServices;
using instapostBusinesslayer.Repository;
using instapostBusinesslayer.Service.Interface;
using instapostBusinesslayer.ViewModels;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace instapostBusinesslayer.Service.Implementation
{
    public class CategoryService : CategorySInterface
    {
        private CategoryRepository cr;
        public CategoryService(CategoryRepository crs)
        {
            cr = crs;
        }

        public Task<long> CreateCategory(CategoryModel cm)
        {
            return null;
        }

        public Task<bool> UpdateCategory(CategoryModel cm)
        {
            return null;
        }

        public Task<CategoryModel> GetCategoryById(long id)
        {
            return null;
        }

        public Task<List<CategoryModel>> GetAllCategory()
        {
            return null;
        }
    }
}