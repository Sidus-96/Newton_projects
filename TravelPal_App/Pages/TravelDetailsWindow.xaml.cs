using System;
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
            foreach (var country in Enum.GetValues(typeof(Countries_s)))
            {
                comboCountriesDetail.Items.Add(country);
            }

            for (int nmr = 1; nmr < 11; nmr++) //Lägga in 1-10 på antalet människor som ska åka
            {
                cmbNumberOfTravelersDetail.Items.Add(nmr.ToString());
            }
            for (int nmr = 1; nmr < 101; nmr++) //Lägga in quantity 1-100
            {
                comboboxQuantityPack.Items.Add(nmr.ToString());
            }




            int selected_id = TravelManager.SelectedId.SelectedId; //DENNA METODEN FUNKAR

            foreach (Travel travel in TravelManager.Travelsadded)
            {

                if (UserManager.SignedInUser?.Username == travel.User && travel.Id == selected_id)
                {
                    //   lstTravelDetails.Items.Add(newItem: new Travel { Id = travel.Id, Country = travel.Country, TypeOfTravel = travel.TypeOfTravel });
                    comboCountriesDetail.Text = travel.Country;
                    //  MessageBox.Show(travel.Country);
                    cmbTypeOfTravelDetails.Text = travel.TypeOfTravel;
                    cmbNumberOfTravelersDetail.Text = travel.NumberOfTravelers.ToString();

                    // WorkDetails.Text = travel.Country;

                    switch (travel.TypeOfTravel) //För att visa och dölja beroende på om man har valt Vaccation eller Work
                    {
                        case "Vaccation":
                            chkboxAllInclusiveDetails.Visibility = System.Windows.Visibility.Visible;
                            if (travel.Allinclusive == "yes")
                            {
                                chkboxAllInclusiveDetails.IsChecked = true;
                            }

                            stkPanelWorkDetails.Visibility = System.Windows.Visibility.Collapsed;
                            break;

                        case "Work":
                            stkPanelWorkDetails.Visibility = System.Windows.Visibility.Visible;
                            txtWorkDetailsDetails.Text = travel.WorkDetails.ToString();
                            chkboxAllInclusiveDetails.Visibility = System.Windows.Visibility.Collapsed;
                            break;
                    } //Se om det är en work eller vaccation

                    calenderdateFromDetails.Text = travel.FromDate;
                    calenderdateToDetails.Text = travel.ToDate;

                    foreach (Pack_Item packitem in TravelManager.Pack_Items)
                    {
                        if (packitem.Id == selected_id)
                        {
                            lstPackItemsDetails.Items.Add(new Pack_Item { PackItem = packitem.PackItem, PackItemQuantity = packitem.PackItemQuantity, PackItemIsRequired = packitem.PackItemIsRequired });
                        }
                    }
                }



            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void cmbTypeOfTravelDetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void chkboxTravelDocument_CheckedDetails(object sender, RoutedEventArgs e)
        {
            txtItemPacklist.Text = "Passport";
            txtItemPacklist.IsEnabled = false;
        }
        private void chkboxTravelDocument_UnCheckedDetails(object sender, RoutedEventArgs e)
        {
            txtItemPacklist.Clear();
            txtItemPacklist.IsEnabled = true;
        }

        private void btnAddItemPackList_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
