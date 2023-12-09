using GreenThumb.Models;

namespace GreenThumb.Database
{
    public class UserRepository
    {
        private readonly GreenThumbDbContext _context;

        public UserRepository(GreenThumbDbContext context)
        {
            _context = context;
        }
        public void Add(UserModel userModel) //Lägga till user
        {
            _context.User.Add(userModel);
        }


    }
}
