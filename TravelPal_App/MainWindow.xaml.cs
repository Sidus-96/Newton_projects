using System.Windows;
using TravelPal_App.Managers;
using TravelPal_App.Models;

namespace TravelPal_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }





        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            string username = txtUserNameSignIn.Text.ToLower();
            string password = txtPasswordSignIn.Password;
            if (username == "" || username == null)
            {
                User newUser = new("User not found", "password", "country");
                UserManager.SignedInUser = newUser;


            }

            bool successLogIn = UserManager.SignInUser(username, password);
            if (successLogIn)
            {
                TravelWindow travelwindow = new TravelWindow();
                travelwindow.Show();
                Close();
            }
            else
            {
                //  MessageBox.Show("Invalid username or password!", "Warning");
                TravelWindow travelwindow = new TravelWindow();
                travelwindow.Show();
                Close();

            }
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }
    }
}
