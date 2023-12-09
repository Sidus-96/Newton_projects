using System.ComponentModel.DataAnnotations;

namespace GreenThumb.Models
{
    public class GardenModel
    {
        [Key]
        public int Id { get; set; }
        public int? PlantId { get; set; }
        public int UserId { get; set; }
        public UserModel? User { get; set; } = null!;
    }
}
