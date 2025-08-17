using instapostBusinesslayer.Interface.UserInterface;
using instapostBusinesslayer.Service.Interface;
using instapostBusinesslayer.ViewModels;
using instapostEntitylayer;

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
            var ue = new UserEntity();
            ue.username = um.username;
            ue.email = um.email;
            ue.password = um.password;
            ue.posts = null;
            ue.userInterestInCategory = null;

            var res = await ur.CreateUser(ue);
            return res;
        }

        public async Task<UserModel> GetUserById(long id)
        {
            var res = await ur.GetUserById(id);
            Console.WriteLine("user by id"+res.posts);

            var um = new UserModel();
            um.id = res.id;
            um.username = res.username;
            um.email = res.email;
            um.password = res.password;
            if (res.posts == null)
            {
                um.posts = null;
            }
            else
            {
                um.posts=res.posts.Select(p => new PostModel
                {
                    id = p.id,
                    postDesc = p.postDesc
                }).ToList();
            }

            if (res.userInterestInCategory == null)
            {
                um.userInterestInCategory = null;
            }
            else
            {
                um.userInterestInCategory=res.userInterestInCategory.Select(c => new CategoryModel
                {
                    id = c.id,
                    categoryName = c.categoryName
                }).ToList();
            }
            return um;
        }

        public async Task<bool> UpdateUser(long userId, long[] categoryId)
        {
            var res = await ur.UpdateUser(userId, categoryId);
            return res;
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            var res = await ur.GetAllUsers();
            var ans = res.Select(u => new UserModel
            {
                id = u.id,
                username = u.username,
                email = u.email,
                password = u.password,
                posts = u.posts.Select(p => new PostModel
                {
                    id = p.id,
                    postDesc = p.postDesc
                }).ToList(),
                userInterestInCategory = u.userInterestInCategory.Select(c => new CategoryModel
                {
                    id = c.id,
                    categoryName = c.categoryName
                }).ToList()

            }).ToList();

            return ans;
        }
    }
}