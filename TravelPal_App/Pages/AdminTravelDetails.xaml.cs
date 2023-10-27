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
    public partial class AdminTravelDetails : Page
    {

        int selected_id;


        public AdminTravelDetails()
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




            selected_id = TravelManager.SelectedId.SelectedId; //DENNA METODEN FUNKAR

            foreach (Travel travel in TravelManager.Travelsadded)
            {

                if (travel.Id == selected_id)
                {
                    //   lstTravelDetails.Items.Add(newItem: new Travel { Id = travel.Id, Country = travel.Country, TypeOfTravel = travel.TypeOfTravel });
                    comboCountriesDetail.Text = travel.Country;
                    txtCityDetails.Text = travel.City;
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
                    txtLengthOfTrip.Text = (DateTime.Parse(travel.ToDate) - DateTime.Parse(travel.FromDate)).Days.ToString();

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

            switch (cmbTypeOfTravelDetails.SelectedIndex) //För att visa och dölja beroende på om man har valt Vaccation eller Work
            {
                case 0:
                    chkboxAllInclusiveDetails.Visibility = System.Windows.Visibility.Visible;
                    stkPanelWorkDetails.Visibility = System.Windows.Visibility.Collapsed;
                    break;

                case 1:
                    stkPanelWorkDetails.Visibility = System.Windows.Visibility.Visible;
                    chkboxAllInclusiveDetails.Visibility = System.Windows.Visibility.Collapsed;
                    break;
            }
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
            string packItemName = txtItemPacklist.Text;
            string? packItemQuantity = comboboxQuantityPack.SelectedItem.ToString();
            string? isrequired = "";
            if (packItemName.Trim() == null || packItemName == "")
            {
                MessageBox.Show("You need to add an item first", "Warning");
            }
            else
            {
                lstPackItemsDetails.Items.Add(new Pack_Item { PackItem = packItemName, PackItemQuantity = packItemQuantity, PackItemIsRequired = isrequired });
            }
        }
        private void DateTimechanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtLengthOfTrip.Text.Length > 0)
            {
                txtLengthOfTrip.Text = (DateTime.Parse(calenderdateToDetails.Text) - DateTime.Parse(calenderdateFromDetails.Text)).Days.ToString();
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            comboCountriesDetail.IsEnabled = true;
            txtCityDetails.IsEnabled = true;
            cmbTypeOfTravelDetails.IsEnabled = true;
            txtWorkDetailsDetails.IsEnabled = true;
            chkboxAllInclusiveDetails.IsEnabled = true;
            cmbNumberOfTravelersDetail.IsEnabled = true;
            calenderdateFromDetails.IsEnabled = true;
            calenderdateToDetails.IsEnabled = true;
            chkboxTravelDocument.IsEnabled = true;
            txtItemPacklist.IsEnabled = true;
            btnAddItemPackList.IsEnabled = true;
            btnSave.IsEnabled = true;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            foreach (Travel travelUpdate in TravelManager.Travelsadded)
            {
                if (travelUpdate.Id == selected_id)
                {

                    travelUpdate.Country = comboCountriesDetail.Text;
                    travelUpdate.City = txtCityDetails.Text;
                    travelUpdate.TypeOfTravel = cmbTypeOfTravelDetails.Text;
                    travelUpdate.WorkDetails = txtWorkDetailsDetails.Text;
                    string allinclusive_text = "";
                    if (chkboxAllInclusiveDetails.IsChecked.Value == true)
                    { allinclusive_text = "yes"; }
                    else
                    {
                        allinclusive_text = "no";
                    }
                    travelUpdate.Allinclusive = allinclusive_text;
                    travelUpdate.NumberOfTravelers = Int32.Parse(cmbNumberOfTravelersDetail.Text);
                    travelUpdate.FromDate = calenderdateFromDetails.Text;
                    travelUpdate.ToDate = calenderdateToDetails.Text;
                }
            }
            MessageBox.Show("Trip updated");
            NavigationService.Navigate(new Uri("pages/admindashboard.xaml", UriKind.Relative));
        }
    }
}