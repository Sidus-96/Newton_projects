using GreenThumb.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumb.Database
{
    internal class GreenThumbDbContext : DbContext
    {


        public GreenThumbDbContext()
        {

        }
        public DbSet<PlantModel> Plants { get; set; }
        public DbSet<InstructionModel> Instructions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = GreenThumbDb; Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PlantModel>()
               .HasData(
               new PlantModel()
               {
                   Id = 1,
                   Name = "Lilja"
               },
                   new PlantModel()
                   {
                       Id = 2,
                       Name = "sommarväxt"
                   });
            modelBuilder.Entity<InstructionModel>()
              .HasData(
              new InstructionModel()
              {
                  Id = 1,
                  PlantID = 1,
                  Instruction = "Vattna"
              },
                  new InstructionModel()
                  {
                      Id = 2,
                      PlantID = 1,
                      Instruction = "VästLäge"
                  },
                       new InstructionModel()
                       {
                           Id = 3,
                           PlantID = 2,
                           Instruction = "Vattna lite sådär"

                       });

        }

    }


}
