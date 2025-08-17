using instapostBusinesslayer.ViewModels;

namespace instapostBusinesslayer.Service.Interface
{
    public interface UserSInterface
    {
        Task<long> CreateUser(UserModel ue);
        Task<UserModel> GetUserById(long id);

        Task<bool> UpdateUser(long userId, long[] categoryId);

        Task<List<UserModel>> GetAllUsers();
    }
}