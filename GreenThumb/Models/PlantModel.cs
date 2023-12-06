using System.ComponentModel.DataAnnotations;

namespace GreenThumb.Models
{
    internal class PlantModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<InstructionModel> Instructions { get; set; } = new();


    }
}
