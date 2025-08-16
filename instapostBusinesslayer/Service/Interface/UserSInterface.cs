using instapostBusinesslayer.ViewModels;

namespace instapostBusinesslayer.Service.Interface
{
    public interface UserSInterface
    {
        Task<int> CreateUser(UserModel ue);
        Task<UserModel> GetUserById(long id);

        Task<bool> UpdateUser(UserModel ue);

        Task<List<UserModel>> GetAllUsers();
    }
}