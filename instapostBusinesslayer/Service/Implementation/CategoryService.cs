using System.Runtime.CompilerServices;
using instapostBusinesslayer.Interface.CategoryInterface;
using instapostBusinesslayer.Repository;
using instapostBusinesslayer.Service.Interface;
using instapostBusinesslayer.ViewModels;
using instapostEntitylayer;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace instapostBusinesslayer.Service.Implementation
{
    public class CategoryService : CategorySInterface
    {
        private readonly CategoryIRepository cr;
        public CategoryService(CategoryIRepository crs)
        {
            cr = crs;
        }

        public Task<long> CreateCategory(CategoryModel cm)
        {
            var ce = new CategoryEntity();
            ce.categoryName = cm.categoryName;

            cr.CreateCategory(ce);
            return null;
        }

        public Task<bool> UpdateCategory(CategoryModel cm)
        {

            return null;
        }

        public async Task<CategoryModel> GetCategoryById(long id)
        {
            var res=await cr.GetCategoryById(id);
            // we get the response in the form of category but we had to change the category model
            CategoryModel cm = new CategoryModel();
            cm.id = res.id;
            cm.categoryName = res.categoryName;
            cm.posts = res.posts.Select(p=>new PostModel
            {
                id = p.id,
                postDesc = p.postDesc,
                postCategory = p.postCategory.Select(c => new CategoryModel{
                    id = c.id,
                    categoryName = c.categoryName
                }).ToList()
                
            }).ToList();
            cm.users = res.users.Select(u => new UserModel
            {
                id = u.id,
                username = u.username,
                email=u.email,
                password=u.password
            }).ToList();
            // cm.users = res.users;
            return cm;
        }

        public Task<List<CategoryModel>> GetAllCategory()
        {
            var res=cr.GetAllCategory();
            return null;
        }
    }
}