using GreenThumb.Models;

namespace GreenThumb.Database
{
    internal class PlantRepository
    {
        private readonly GreenThumbDbContext _context;
        public PlantRepository(GreenThumbDbContext context)
        {
            _context = context;
        }

        public List<PlantModel> GetAll()
        {
            return _context.Plants.ToList();
        }

        public void Add(PlantModel plantModel)
        {
            _context.Plants.Add(plantModel);
        }

    }
}
