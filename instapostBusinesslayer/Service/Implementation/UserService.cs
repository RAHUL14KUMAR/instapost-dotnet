using instapostBusinesslayer.Interface.UserInterface;
using instapostBusinesslayer.Service.Interface;
using instapostBusinesslayer.ViewModels;

namespace instapostBusinesslayer.Service.Implementation
{
    public class UserService : UserSInterface
    {
        private readonly UserIRepository ur;
        public UserService(UserIRepository ur)
        {
            this.ur = ur;
        }

        public async Task<long> CreateUser(UserModel um)
        {
            return 0;
        }

        public async Task<UserModel> GetUserById(long id)
        {
            return null;
        }

        public async Task<bool> UpdateUser(UserModel um)
        {
            return false;
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            return null;
        }
    }
}