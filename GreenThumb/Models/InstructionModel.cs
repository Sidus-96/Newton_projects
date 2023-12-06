using System.ComponentModel.DataAnnotations;

namespace GreenThumb.Models
{
    internal class InstructionModel
    {
        [Key]
        public int Id { get; set; }
        public int PlantID { get; set; }
        public string Instruction { get; set; } = null!;



    }
}
