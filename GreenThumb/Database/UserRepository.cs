using GreenThumb.Models;

namespace GreenThumb.Database
{
    internal class UserRepository
    {
        private readonly GreenThumbDbContext _context;

        public UserRepository(GreenThumbDbContext context)
        {
            _context = context;
        }
        public void Add(PlantModel userModel) //Lägga till user
        {
            _context.Plants.Add(userModel);
        }

    }
}
