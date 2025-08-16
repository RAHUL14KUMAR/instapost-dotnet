using instapostBusinesslayer.ViewModels;

namespace instapostBusinesslayer.Service.Interface
{
    public interface PostSInterface
    {
        Task<int> CreatePost(PostModel pe);
        Task<bool> UpdatePost(PostModel pe);

        Task<PostModel> GetPostById(long id);

        Task<List<PostModel>> GetAllPost(); 
    }
}