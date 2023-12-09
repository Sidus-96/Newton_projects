using GreenThumb.Database;
using GreenThumb.Manager;
using GreenThumb.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{

    /// <summary>
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window
    {
        public string Plantname { get; private set; }
        public int PlantDetailId { get; set; }

        public PlantDetailsWindow(string plantname, int plantId)
        {
            InitializeComponent();

            Plantname = plantname;
            PlantDetailId = plantId;
            txtAddInstruction.IsEnabled = false;
            txtchangeplant.IsEnabled = false;
            btnAddInsctruction.IsEnabled = false;
            btnSaveChanges.IsEnabled = false;
            btnAddInsctruction.IsEnabled = false;
            btnEditInsctruction.IsEnabled = false;
            txtchangeplant.Text = plantname;
            getAll();






        }

        private void btnUnlockinputs_Click(object sender, RoutedEventArgs e)
        {
            txtAddInstruction.IsEnabled = true;
            txtchangeplant.IsEnabled = true;
            btnEditInsctruction.IsEnabled = true;
            btnSaveChanges.IsEnabled = true;

        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantwindow = new PlantWindow();
            plantwindow.Show();
            Close();
        }

        private void btnAddInsctruction_Click(object sender, RoutedEventArgs e)
        {
            lstDetailsInstructions.Items.Add(txtAddInstruction.Text);
            using (GreenThumbDbContext context = new())
            {
                instructionRepository instructionRepository = new(context);


                InstructionModel newinstruction = new InstructionModel();

                newinstruction.Instruction = txtAddInstruction.Text;
                newinstruction.PlantId = PlantDetailId;
                instructionRepository.Add(newinstruction);



                context.SaveChanges();
                txtAddInstruction.Clear();
                MessageBox.Show("Instruction Added");
            }
        }

        private void txtAddInstruction_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtAddInstruction.Text.Trim() == "")
            {
                btnAddInsctruction.IsEnabled = false;
            }
            else
            {
                btnAddInsctruction.IsEnabled = true;
            }
        }

        private void lstDetailsInstructions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstDetailsInstructions.SelectedItem;
            if (selectedItem != null)
            {
                InstructionModel selectInstruction = (InstructionModel)selectedItem.Tag;
                txtEditInstruction.Text = selectInstruction.Instruction;
            }
        }

        public void btnEditInsctruction_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstDetailsInstructions.SelectedItem;
            if (selectedItem != null)
            {
                InstructionModel selectInstruction = (InstructionModel)selectedItem.Tag;
                // txtEditInstruction.Text = selectInstruction.Instruction;

                using (GreenThumbDbContext context = new())
                {
                    InstructionModel updateInstruction = new();
                    updateInstruction.Instruction = txtEditInstruction.Text;

                    instructionRepository instructionRepository = new(context);
                    instructionRepository.Update(selectInstruction.Id, updateInstruction);
                    context.SaveChanges();//sparar för att få fram id så instruktioner kan komma till växten

                    txtEditInstruction.Clear();
                }
            }

            getAll();
        }
        public void getAll()
        {
            lstDetailsInstructions.Items.Clear();
            using (GreenThumbDbContext context = new())
            {
                var instructionsplant = context.Plants.Include(w => w.Instructions).First(w => w.Name == Plantname);
                foreach (var instruction in instructionsplant.Instructions)
                {
                    ListViewItem item = new();
                    item.Tag = instruction;
                    item.Content = instruction.Instruction;

                    lstDetailsInstructions.Items.Add(item);
                }
            }

        }

        private void btnAddToGarden_Click(object sender, RoutedEventArgs e)
        {
            using (GreenThumbDbContext context = new())
            {
                GardenRepository gardenRepository = new(context);


                GardenModel newgarden = new GardenModel();

                newgarden.UserId = UserManager.SignedInUser;
                newgarden.PlantId = PlantDetailId;

                gardenRepository.Add(newgarden);



                context.SaveChanges();
                MessageBox.Show("Plant added to your garden");

            }
        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (Plantname != txtchangeplant.Text)
            {
                using (GreenThumbDbContext context = new())
                {
                    PlantRepository plantRepository = new(context);


                    PlantModel updatePlant = new PlantModel();


                    updatePlant.Name = txtchangeplant.Text;

                    plantRepository.Update(PlantDetailId, updatePlant);



                    context.SaveChanges();
                    MessageBox.Show("Plant updated");

                }
            }

        }
    }
}

