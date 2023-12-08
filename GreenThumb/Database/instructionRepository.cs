using GreenThumb.Models;

namespace GreenThumb.Database
{
    public class instructionRepository
    {
        private readonly GreenThumbDbContext _context;
        public instructionRepository(GreenThumbDbContext context)
        {
            _context = context;
        }
        public void Add(InstructionModel instructionModel)
        {
            _context.Instructions.Add(instructionModel);
        }
        public void Update(int id, InstructionModel instructionModel)
        {
            InstructionModel? updateinstruction = _context.Instructions.FirstOrDefault(p => p.Id == id);

            if (updateinstruction != null)
            {
                updateinstruction.Instruction = instructionModel.Instruction;

            }
        }


    }
}
