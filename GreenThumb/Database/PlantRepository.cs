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

        public void Update(int id, PlantModel plantmodel)
        {
            PlantModel? plantupdate = _context.Plants.FirstOrDefault(p => p.Id == id);

            if (plantupdate != null)
            {
                plantupdate.Name = plantmodel.Name;

            }
        }

        public int Delete(string name)
        {
            PlantModel? plantDelete = _context.Plants.FirstOrDefault(p => p.Name == name);

            if (plantDelete != null)
            {
                _context.Plants.Remove(plantDelete);
                return plantDelete.Id;
            }
            else
                return 0;
        }

    }
}
