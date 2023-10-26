using System.Windows;
using System.Windows.Controls;
using TravelPal_App.Managers;
using TravelPal_App.Models;

namespace TravelPal_App.Pages
{
    /// <summary>
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Page
    {




        public TravelDetailsWindow()
        {

            InitializeComponent();
            int selected_id = TravelManager.SelectedId.SelectedId; //DENNA METODEN FUNKAR

            foreach (Travel travel in TravelManager.Travelsadded)
            {

                if (UserManager.SignedInUser?.Username == travel.User && travel.Id == selected_id)
                {
                    lstTravelDetails.Items.Add(newItem: new Travel { Id = travel.Id, Country = travel.Country, TypeOfTravel = travel.TypeOfTravel });
                    MessageBox.Show(travel.Country);
                    WorkDetails.Text = travel.Country;
                }



            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
