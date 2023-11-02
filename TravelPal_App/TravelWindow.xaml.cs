using System.Windows;
using TravelPal_App.Managers;
using TravelPal_App.Pages;

namespace TravelPal_App
{
    /// <summary>
    /// Interaction logic for TravelWindow.xaml
    /// </summary>
    public partial class TravelWindow : Window
    {
        public TravelWindow()
        {
            InitializeComponent();
            lblSignedInUser.Content = UserManager.SignedInUser.Username;
            _mainframeWindow.Navigate(new TravelDashBoard());

            if (UserManager.SignedInUser.Username == "admin")
            {
                btnAdmin.Visibility = Visibility.Visible;
                btnAdmin.IsEnabled = true;
            }

            if (UserManager.SignedInUser.Welcomemsg == false)
            {
                MessageBoxResult msgbox = MessageBox.Show("Welcome to TravelPal! \n Would you like to see some information about the app? \n *You can always find this information at the information button later on", "Information", MessageBoxButton.YesNo);
                if (msgbox == MessageBoxResult.Yes)
                {
                    _mainframeWindow.Navigate(new InformationUser());
                    UserManager.SignedInUser.Welcomemsg = true;
                }
                else if (msgbox == MessageBoxResult.No)
                {
                    _mainframeWindow.Navigate(new TravelDashBoard());
                    UserManager.SignedInUser.Welcomemsg = true;
                }

            }
        }

        private void userSettings_Click(object sender, RoutedEventArgs e)
        {
            _mainframeWindow.Content = new UserDetails();
        }

        private void btnDashBoard_Click(object sender, RoutedEventArgs e)
        {
            _mainframeWindow.Content = (new TravelDashBoard());
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            _mainframeWindow.Content = new AddTravelPage();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            UserManager.SignOutUser();
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            Close();
        }

        private void _mainframeWindow_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            lblSignedInUser.Content = UserManager.SignedInUser.Username;
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            _mainframeWindow.Content = new AdminDashBoard();
        }

        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            _mainframeWindow.Content = new InformationUser();
        }
    }
}
