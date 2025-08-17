using instapostEntitylayer;

namespace instapostBusinesslayer.Interface.PostInterface
{
    public interface PostIRepository
    {
        Task<long> CreatePost(PostEntity pe);
        Task<bool> UpdatePost(PostEntity pe);

        Task<PostEntity> GetPostById(long id);

        Task<List<PostEntity>> GetAllPost();   
    }
}