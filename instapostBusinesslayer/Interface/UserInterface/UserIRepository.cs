using instapostEntitylayer;

namespace instapostBusinesslayer.Interface.UserInterface
{
    public interface UserIRepository
    {
        Task<int> CreateUser(UserEntity ue);
        Task<UserEntity> GetUserById(long id);

        Task<bool> UpdateUser(UserEntity ue);

        Task<List<UserEntity>> GetAllUsers();

    }
}