using System;
using System.Windows;
using System.Windows.Controls;
using TravelPal_App.Managers;
using TravelPal_App.Models;

namespace TravelPal_App.Pages
{
    /// <summary>
    /// Interaction logic for TravelDashBoard.xaml
    /// </summary>
    public partial class TravelDashBoard : Page
    {
        public TravelDashBoard()
        {
            InitializeComponent();



            foreach (Travel travel in TravelManager.Travelsadded)
            {

                if (UserManager.SignedInUser.Username == travel.User)
                {
                    LstDashBoard.Items.Add(new Travel { Id = travel.Id, Country = travel.Country, TypeOfTravel = travel.TypeOfTravel });
                }
            }


        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            int travelIndex = LstDashBoard.SelectedIndex;
            var travelId = LstDashBoard.SelectedItems[0];
            TravelManager.SetSelectedId(((TravelPal_App.Models.Travel)travelId).Id);



            NavigationService.Navigate(new Uri("pages/TravelDetailsWindow.xaml", UriKind.Relative));


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
