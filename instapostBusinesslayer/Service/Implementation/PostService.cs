using instapostBusinesslayer.Interface.PostInterface;
using instapostBusinesslayer.Service.Interface;
using instapostBusinesslayer.ViewModels;
using Npgsql.Replication;

namespace instapostBusinesslayer.Service.Implementation
{
    public class PostService : PostSInterface
    {
        private readonly PostIRepository pr;
        public PostService(PostIRepository pr)
        {
            this.pr = pr;
        }

        public Task<long> CreatePost(PostModel pm)
        {
            return null;
        }
        public Task<bool> UpdatePost(PostModel pm)
        {
            return null;
        }

        public Task<PostModel> GetPostById(long id)
        {
            return null;
        }
        public Task<List<PostModel>> GetAllPost()
        {
            return null;
        }
    }
}