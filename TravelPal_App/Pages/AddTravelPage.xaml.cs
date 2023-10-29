using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using TravelPal_App.Managers;
using TravelPal_App.Models;

namespace TravelPal_App.Pages
{
    /// <summary>
    /// Interaction logic for AddTravelPage.xaml
    /// </summary>
    public partial class AddTravelPage : Page
    {
        public AddTravelPage()
        {
            InitializeComponent();


            foreach (var country in Enum.GetValues(typeof(Countries_s)))
            {



                comboCountries.Items.Add(country);
            }

            for (int nmr = 1; nmr < 11; nmr++) //Lägga in 1-10 på antalet människor som ska åka
            {
                cmbNumberOfTravelers.Items.Add(nmr.ToString());
            }
            for (int nmr = 1; nmr < 101; nmr++) //Lägga in quantity 1-100
            {
                comboboxQuantityPack.Items.Add(nmr.ToString());
            }

        }





        private void comboTypeOfTravel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbTypeOfTravel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (cmbTypeOfTravel.SelectedIndex) //För att visa och dölja beroende på om man har valt Vacation eller Work
            {
                case 0:
                    chkboxAllInclusive.Visibility = System.Windows.Visibility.Visible;
                    stkPanelWork.Visibility = System.Windows.Visibility.Collapsed;
                    break;

                case 1:
                    stkPanelWork.Visibility = System.Windows.Visibility.Visible;
                    chkboxAllInclusive.Visibility = System.Windows.Visibility.Collapsed;
                    break;
            }
        }

        private void chkboxTravelDocument_Checked(object sender, RoutedEventArgs e)
        {
            txtItemPacklist.Text = "Passport";
            txtItemPacklist.IsEnabled = false;
        }
        private void chkboxTravelDocument_UnChecked(object sender, RoutedEventArgs e)
        {
            txtItemPacklist.Clear();
            txtItemPacklist.IsEnabled = true;
        }

        private void btnAddItemPackList_Click(object sender, RoutedEventArgs e)
        {


            string packItemName = txtItemPacklist.Text;
            string? packItemQuantity = comboboxQuantityPack.SelectedItem.ToString();

            string? isrequired = "";
            if (chkboxTravelDocument.IsChecked == true)
            {
                foreach (var country in Enum.GetValues(typeof(Countries_s)))
                {

                    string country_check = country.ToString();
                    if (country_check == comboCountries.SelectedItem.ToString())
                    {
                        if (Enum.IsDefined(typeof(Countries_Europe), country_check) && Enum.IsDefined(typeof(Countries_Europe), UserManager.SignedInUser.Country))
                        {
                            isrequired = "no";
                        }
                        else if (Enum.IsDefined(typeof(Countries_Europe), UserManager.SignedInUser.Country) == false)
                        {
                            isrequired = "yes";
                        }
                        else
                        {
                            isrequired = "yes";
                        }


                    }
                }
            }
            if (packItemName.Trim() == null || packItemName == "")
            {
                MessageBox.Show("You need to add an item first", "Warning");
            }
            else
            {
                lstViewPackList.Items.Add(new Pack_Item { PackItem = packItemName, PackItemQuantity = packItemQuantity, PackItemIsRequired = isrequired });
            }


        }

        private void btnSaveTravel_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                string country = comboCountries.SelectedItem.ToString();
                string? city = txtCity.Text;
                string? typeOfTravel = cmbTypeOfTravel.Text;
                int numberOftravelers = Int32.Parse(cmbNumberOfTravelers.Text);
                bool checkAllInClusive = chkboxAllInclusive.IsChecked.Value;
                string? workDetails = txtWorkDetails.Text;
                string? fromDate = calenderdateFrom.SelectedDate.Value.ToString("yyyy.MM.dd", CultureInfo.InvariantCulture);
                string? toDate = calenderdateTo.SelectedDate.Value.ToString("yyyy.MM.dd", CultureInfo.InvariantCulture);



                foreach (var item in lstViewPackList.Items) //Lägga till saker i listan för den nuvarande resan.

                {
                    TravelManager.AddPackItem(((TravelPal_App.Models.Pack_Item)item).PackItem, ((TravelPal_App.Models.Pack_Item)item).PackItemQuantity, ((TravelPal_App.Models.Pack_Item)item).PackItemIsRequired);
                }
                TravelManager.AddTravel(country, city, typeOfTravel, numberOftravelers, checkAllInClusive, workDetails, fromDate, toDate);
                MessageBox.Show("Travel added to list \n See Dashboard for your added trips.", "TravelPal");
                ClearInput();

            }
            catch (Exception ex) when (ex is InvalidOperationException || ex is System.NullReferenceException)
            {
                MessageBox.Show("Please fill in all required fields\n" + "Country\n" + "Type of travel\n" + "From date\n" + "To date\n", "Warning");
            }
        }
        private void ClearInput()
        {
            this.NavigationService.Navigate(new Uri("Pages/addTravelPage.xaml", UriKind.Relative)); //För att rensa inputs, laddade om hela sidan då sidan endast är till för nya resor.
        }

    }
}
