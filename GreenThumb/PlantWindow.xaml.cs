using GreenThumb.Database;
using GreenThumb.Models;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for PlantWindow.xaml
    /// </summary>
    public partial class PlantWindow : Window
    {
        public PlantWindow()
        {
            InitializeComponent();

            GetAllPlants();

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            using (GreenThumbDbContext context = new())
            {
                string searchword = txtSearchbar.Text.Trim().ToLower();
                var planta = context.Plants.FirstOrDefault(p => p.Name == searchword);
                if (planta != null)
                {
                    lstPlant.Items.Clear();
                    lstPlant.Items.Add(new PlantModel { Name = planta.Name });
                }
                else
                {
                    MessageBox.Show($"{searchword} Could not be found");
                }

            }

        }

        private void btnResetSearch_Click(object sender, RoutedEventArgs e)
        {

            GetAllPlants();

        }



        private void btnDeletePlant_Click(object sender, RoutedEventArgs e)
        {
            using (GreenThumbDbContext context = new())
            {
                if (lstPlant.SelectedIndex < 0)
                {
                    MessageBox.Show("You need choose a plant first");
                }
                else
                {
                    MessageBoxResult answer = MessageBox.Show($"Do you want to delete the selected plant?\n" + "All care insctructions will also be removed", "Confirmation", MessageBoxButton.YesNo);
                    if (answer == MessageBoxResult.Yes)
                    {


                        var selectedPlant = lstPlant.SelectedItem;
                        string plantToDelete = ((GreenThumb.Models.PlantModel)selectedPlant).Name;


                        PlantRepository plantRepository = new(context);
                        plantRepository.Delete(plantToDelete);
                        context.SaveChanges();
                        GetAllPlants();
                        MessageBox.Show("Plant deleted", "Success");


                    }


                }
            }
        }


        public void GetAllPlants()
        {
            lstPlant.Items.Clear();
            using (GreenThumbDbContext context = new())
            {
                PlantRepository plantRepository = new(context);

                var plants = plantRepository.GetAll();

                foreach (var plant in plants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name;

                    lstPlant.Items.Add(item);
                }
            }
        }

        private void btnPlantWindow_Click(object sender, RoutedEventArgs e)
        {
            AddPlantWindow addPlantWindow = new AddPlantWindow();
            addPlantWindow.Show();
            Close();

        }



        private void btnPlantDetails_Click_1(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstPlant.SelectedItem;
            if (selectedItem != null)
            {
                PlantModel selectPlant = (PlantModel)selectedItem.Tag;
                string plantName = selectPlant.Name;
                int plantId = selectPlant.Id;
                PlantDetailsWindow plantDetailsWindow = new PlantDetailsWindow(plantName, plantId);
                plantDetailsWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Chosse a plant first");
            }
        }
    }
}
