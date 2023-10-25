using System.Windows;
using System.Windows.Controls;
using TravelPal_App.Managers;

namespace TravelPal_App.Pages
{
    /// <summary>
    /// Interaction logic for UserDetails.xaml
    /// </summary>
    public partial class UserDetails : Page
    {
        public UserDetails()
        {
            InitializeComponent();
            txtUsernameDetails.Text = UserManager.SignedInUser.Username;
            //lägg in current country på användaren
        }

        private void SaveNewUserDetails_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChangeUserName_Click(object sender, RoutedEventArgs e)
        {
            if (expanderUserName.Visibility == Visibility.Collapsed)
            {
                expanderUserName.Visibility = Visibility.Visible;
            }
            else
            {
                expanderUserName.Visibility = Visibility.Collapsed;
            }
        }

        private void btnChangePasswordExpand_Click(object sender, RoutedEventArgs e)
        {
            if (expanderPassword.Visibility == Visibility.Collapsed)
            {
                expanderPassword.Visibility = Visibility.Visible;
            }
            else
            {
                expanderPassword.Visibility = Visibility.Collapsed;
            }
        }
    }
}
