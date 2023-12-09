using GreenThumb.Models;

namespace GreenThumb.Database
{
    public class GardenRepository
    {
        private readonly GreenThumbDbContext _context;
        public GardenRepository(GreenThumbDbContext context)
        {
            _context = context;
        }

        public void Add(GardenModel gardenModel)
        {
            _context.Garden.Add(gardenModel);
        }
        public List<GardenModel> GetAll()
        {
            return _context.Garden.ToList();
        }

        public void Delete(int plantId)
        {
            GardenModel? removeplantFromGarden = _context.Garden.FirstOrDefault(p => p.PlantId == plantId);


            _context.Garden.Remove(removeplantFromGarden);


        }



    }
}
