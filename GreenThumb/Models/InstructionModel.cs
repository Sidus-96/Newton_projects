using System.ComponentModel.DataAnnotations;

namespace GreenThumb.Models
{
    internal class InstructionModel
    {
        [Key]
        public int Id { get; set; }
        public string? Instruction { get; set; }
        public int PlantId { get; set; }
        public PlantModel? Plant { get; set; } = null!;








    }
}
