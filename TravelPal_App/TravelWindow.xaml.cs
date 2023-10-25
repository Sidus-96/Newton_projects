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
    }
}
