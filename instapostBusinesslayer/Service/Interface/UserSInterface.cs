using instapostBusinesslayer.ViewModels;

namespace instapostBusinesslayer.Service.Interface
{
    public interface UserSInterface
    {
        Task<long> CreateUser(UserModel ue);
        Task<UserModel> GetUserById(long id);

        Task<bool> UpdateUser(UserModel ue);

        Task<List<UserModel>> GetAllUsers();
    }
}