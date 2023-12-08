using GreenThumb.Models;

namespace GreenThumb.Database
{
    public class PlantRepository
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
        public void Delete(string name)
        {
            PlantModel? plantDelete = _context.Plants.FirstOrDefault(p => p.Name == name);

            if (plantDelete != null)
            {
                _context.Plants.Remove(plantDelete);
            }
        }

    }
}
