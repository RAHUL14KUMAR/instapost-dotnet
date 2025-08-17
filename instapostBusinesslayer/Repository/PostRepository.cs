using instapostBusinesslayer.Interface.PostInterface;
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

        public Task<long> CreatePost(PostEntity pe)
        {
            return null;
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