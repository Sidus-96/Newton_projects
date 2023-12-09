using GreenThumb.Database;
using GreenThumb.Models;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for AddPlantWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        public AddPlantWindow()
        {
            InitializeComponent();
            btnAddPlant.IsEnabled = false;
            btnAddInsctruction.IsEnabled = false;
        }

        private void txtAddPlant_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (GreenThumbDbContext context = new())
            {
                string checkPlantName = txtAddPlant.Text;
                bool plantExist = context.Plants.Where(u => u.Name == checkPlantName).Any();//Kontrollera så att lösenordet och användarnamnet är korrekt innan inloggning
                if (plantExist)
                {
                    btnAddPlant.IsEnabled = false; //om en växt redan finns stäng av add knappen

                    MessageBox.Show("Plant already exist", "Warning");
                }
                else if (txtAddPlant.Text.Trim() == "")
                {
                    btnAddPlant.IsEnabled = false;
                }
                else
                {
                    {
                        btnAddPlant.IsEnabled = true;
                    }
                }
            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantwindow = new PlantWindow();
            plantwindow.Show();
            Close();
        }

        private void btnAddInsctruction_Click(object sender, RoutedEventArgs e)
        {
            string instruction = txtAddInstruction.Text.Trim();
            lstNewInstructions.Items.Add(instruction);

        }

        private void txtAddInsctruction_TextChanged(object sender, TextChangedEventArgs e)
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

        private void btnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            string plantNew = txtAddPlant.Text.Trim();
            using (GreenThumbDbContext context = new())
            {

                MessageBoxResult answer = MessageBox.Show($"Do you want to add your plant?", "Confirmation", MessageBoxButton.YesNo);
                if (answer == MessageBoxResult.Yes)
                {
                    PlantModel newplant = new();
                    newplant.Name = plantNew;

                    PlantRepository plantRepository = new(context);
                    plantRepository.Add(newplant);
                    context.SaveChanges();//sparar för att få fram id så instruktioner kan komma till växten

                    instructionRepository instructionRepository = new(context);

                    for (int i = 0; i < lstNewInstructions.Items.Count; i++) //Looppa igenom listview listan och lägg in i databasen
                    {
                        InstructionModel newinstruction = new InstructionModel();

                        newinstruction.Instruction = lstNewInstructions.Items[i].ToString();
                        newinstruction.PlantId = newplant.Id;
                        instructionRepository.Add(newinstruction);

                    }

                    context.SaveChanges();
                    MessageBox.Show("Plant added", "Success");

                    txtAddInstruction.Clear();
                    lstNewInstructions.Items.Clear();
                }
            }
        }
    }
}
