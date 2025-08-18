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

        public async Task<long> CreatePost(long userId,PostReq pmm)
        {
            var res = await pr.CreatePost(userId, pmm);
            return res;
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