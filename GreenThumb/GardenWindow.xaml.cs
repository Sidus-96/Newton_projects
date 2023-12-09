using GreenThumb.Database;
using GreenThumb.Manager;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for GardenWindow.xaml
    /// </summary>
    public partial class GardenWindow : Window
    {
        public GardenWindow()
        {
            InitializeComponent();

            lstGardenPlants.Items.Clear();

            using (GreenThumbDbContext context = new())
            {
                GardenRepository gardenRepository = new(context);
                PlantRepository plantRepository = new(context);


                var GetAllGardens = gardenRepository.GetAll(); //Ta fram alla Gardens
                var plants = plantRepository.GetAll(); //Ta fram alla Plants

                foreach (var garden in GetAllGardens)
                {
                    if (garden.UserId == UserManager.SignedInUser) //Loopa igenom alla garden och se vilka som matchar användaren
                    {
                        if (garden.PlantId != null)
                        {
                            foreach (var plant in plants)
                            {
                                if (plant.Id == garden.PlantId) //Ta fram vad växten heter och lägg in den i listView
                                {
                                    ListViewItem item = new();
                                    item.Tag = plant;
                                    item.Content = plant.Name;
                                    lstGardenPlants.Items.Add(item);
                                }


                            }
                        }
                    }



                }

            }
        }



        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantWindow = new PlantWindow();
            plantWindow.Show();
            Close();
        }
    }
}

