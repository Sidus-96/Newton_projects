using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TravelPal_App.Managers;
using TravelPal_App.Models;

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
            foreach (var country in Enum.GetValues(typeof(Countries_s)))
            {
                comboCountries.Items.Add(country);
            }
            comboCountries.Text = UserManager.SignedInUser.Country;
        }

        private void SaveNewUserDetails_Click(object sender, RoutedEventArgs e)
        {
            foreach (User userupdate in UserManager.Users.ToList())
            {
                if (UserManager.SignedInUser?.Username == userupdate.Username)
                {


                    string newUsername = txtNewUsername.Text;
                    string newPassword = txtNewPassword.Text;
                    string newPasswordConfirm = txtNewPasswordConfirm.Text;
                    string newCountry = comboCountries.Text;
                    bool updateUserName = false;
                    bool updatePassword = false;
                    bool updateCountry = false;
                    string mUser = "\n";
                    string mPassword = "\n";
                    string mcountry = "\n";


                    if (newUsername.Length > 1)
                    {
                        if (UserManager.ValidateUsername(newUsername) == false)
                        {
                            mUser = "User already exist \n";
                        }
                        if (UserManager.ValidateUsernameLength(newUsername) == false)
                        {
                            mUser += "Username must be longer than 3 characters \n";
                        }
                        else
                        {
                            updateUserName = true;
                        }


                    }

                    if (newPassword != newPasswordConfirm)
                    {

                        mPassword = "Password doesn't match\n";

                    }
                    if (newPassword == newPasswordConfirm && newPassword.Length > 1)
                    {
                        if (UserManager.ValidatePassword(newPassword) == false)
                        {
                            mPassword = "Password need to be longer than 5 signs\n";
                        }
                        else
                        {
                            updatePassword = true;
                        }
                    }
                    if (newCountry != UserManager.SignedInUser.Country)
                    {
                        updateCountry = true;

                    }



                    if (newUsername.Length > 1 && UserManager.ValidateUsername(newUsername) == false || UserManager.ValidatePassword(newPassword) == false && newPassword.Length > 1)
                    {
                        MessageBox.Show(mUser + mPassword, "Warning");

                    }
                    else
                    {
                        if (updateUserName)
                        {
                            userupdate.Username = newUsername;
                            mUser = "Updated username\n";
                            UserManager.SignedInUser.Username = newUsername;
                        }
                        if (updatePassword)
                        {
                            userupdate.Password = newPassword;
                            mPassword = "updated password\n";
                        }
                        if (updateCountry)
                        {
                            userupdate.Country = newCountry;
                            mcountry = "Update country of origin\n";
                        }
                        if (updateUserName == true || updatePassword == true || updateCountry == true)
                        {
                            MessageBox.Show(mUser + mPassword + mcountry, "Success");


                            NavigationService.Navigate(new Uri("pages/UserDetails.xaml", UriKind.Relative));
                        }


                    }

                }
            }

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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("pages/TravelDashBoard.xaml", UriKind.Relative));
        }
    }
}
