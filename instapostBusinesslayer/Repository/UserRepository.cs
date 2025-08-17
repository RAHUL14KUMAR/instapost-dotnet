using instapostBusinesslayer.Interface.UserInterface;
using instapostDataLayer;
using instapostEntitylayer;
using Microsoft.EntityFrameworkCore;

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
            dbContext.UsersDb.Add(ue);
            await dbContext.SaveChangesAsync();
            Console.WriteLine("User added successfull");

            return ue.id;
        }

        public async Task<UserEntity> GetUserById(long id)
        {
            var res = await dbContext.UsersDb
            .Include(u => u.posts)
            // load posts
            .Include(u => u.userInterestInCategory)
            // load categories
            .FirstOrDefaultAsync(u => u.id == id);
            return res;
        }

        public async Task<bool> UpdateUser(long userId, long[] categoryInterest)
        {
            var res = await dbContext.UsersDb.Include(u => u.userInterestInCategory) // load existing relationships
            .FirstOrDefaultAsync(u => u.id == userId);

            Console.WriteLine("user from getid req" + res);

            if (res == null)
            {
                // throw new ArgumentException("user with this id not found");
                return false;
            }

            // Clear existing relationships to avoid duplicates
            res.userInterestInCategory.Clear();

            // Fetch the new categories
            var categories = await dbContext.CategoryDb
                .Where(c => categoryInterest.Contains(c.id))
                .ToListAsync();

            if (categories.Count != categoryInterest.Length)
            {
                return false; // some category IDs not found
            }

            // Assign the new ones (only update one side, EF will maintain the join table)
            foreach (var cat in categories)
            {
                res.userInterestInCategory.Add(cat);
            }

            // now in the category db we had to add the user
            foreach (var cat in categories)
            {
                if (cat.users == null)
                {
                    cat.users = new List<UserEntity>();
                }
                cat.users.Add(res);
            }

            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<UserEntity>> GetAllUsers()
        {
            var ans = await dbContext.UsersDb.Include(u => u.posts).Include(u => u.userInterestInCategory).ToListAsync();
            return ans;
        }
    }
}