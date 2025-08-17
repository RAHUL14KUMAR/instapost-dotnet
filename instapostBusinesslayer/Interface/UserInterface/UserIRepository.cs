using instapostEntitylayer;

namespace instapostBusinesslayer.Interface.UserInterface
{
    public interface UserIRepository
    {
        Task<long> CreateUser(UserEntity ue);
        Task<UserEntity> GetUserById(long id);

        Task<bool> UpdateUser(long userId,long[] categoryInterest);

        Task<List<UserEntity>> GetAllUsers();

    }
}