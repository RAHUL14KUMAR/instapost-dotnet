using System.Reflection.PortableExecutable;
using instapostBusinesslayer.Interface.PostInterface;
using instapostBusinesslayer.ViewModels;
using instapostDataLayer;
using instapostEntitylayer;

namespace instapostBusinesslayer.Repository
{
    public class PostRepository : PostIRepository
    {
        private readonly ApplicationDbContext dbContext;
        public PostRepository(ApplicationDbContext db)
        {
            dbContext = db;
        }

        public async Task<long> CreatePost(long userId, PostReq pm)
        {
            var userExists = await dbContext.UsersDb.FindAsync(userId);
            if (userExists == null)
            {
                return 0;
            }
            PostEntity pe = new PostEntity();
            pe.postDesc = pm.postDesc;

            // assign the user to the post.
            pe.user.Add(userExists);

            // now fetch the category id and each category map the post
            var categories = new List<CategoryEntity>();
            foreach (var id in pm.postCategory)
            {
                var category = await dbContext.CategoryDb.FindAsync(id);

                // in each category id map the posts
                category.posts.Add(pe);

                // add category in the list
                categories.Add(category);

            }
            // assign the categories list in the database
            pe.postCategory = categories; 

            dbContext.PostDb.Add(pe);

            // in user profile map the post details
            userExists.posts.Add(pe);

            await dbContext.SaveChangesAsync();

            return pe.id;
        }

        public Task<bool> UpdatePost(PostEntity pe)
        {
            return null;
        }

        public Task<PostEntity> GetPostById(long id)
        {
            return null;
        }

        public Task<List<PostEntity>> GetAllPost()
        {
            return null;
        }
    }
}