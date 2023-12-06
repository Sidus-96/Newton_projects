using System.ComponentModel.DataAnnotations;

namespace GreenThumb.Models
{
    internal class InstructionModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Instruction { get; set; } = null!;
        public PlantModel? plant { get; set; }





    }
}
