using instapostBusinesslayer.Interface.UserInterface;
using instapostDataLayer;
using instapostEntitylayer;

namespace instapostBusinesslayer.Repository
{
    public class UserRepository : UserIRepository
    {
        private readonly ApplicationDbContext dbContext;
        public UserRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task<long> CreateUser(UserEntity ue)
        {
            return 0;
        }

        public async Task<UserEntity> GetUserById(long id)
        {
            return null;
        }

        public async Task<bool> UpdateUser(UserEntity ue)
        {
            return false;
        }

        public async Task<List<UserEntity>> GetAllUsers()
        {
            return null;
        }
    }
}