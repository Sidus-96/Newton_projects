using System;
using System.Windows;
using TravelPal_App.Managers;
using TravelPal_App.Models;

namespace TravelPal_App
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

        public RegisterWindow()
        {
            InitializeComponent();

            //countries.AddRange(Enum.GetNames(typeof(Countries_s)).ToList()); //Lägga till Enums i lista, flytta ut listan?
            //foreach (string country in countries)
            //{
            //    cmbCountries.Items.Add(country);
            //}
            //  cmbCountries.Items.Add(Enum.GetNames(typeof(Countries_s).));

            foreach (var country in Enum.GetValues(typeof(Countries_s)))
            {
                cmbCountries.Items.Add(country);
            }


        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string RegisteruserName = txtRegisterUsername.Text.ToLower();
            string Registerpassword = txtRegisterPassword.Password;
            string RegisterCountry = cmbCountries.Text;
            string mUser = "\n";
            string mPassword = "\n";
            string mCountry = "\n";


            if (UserManager.ValidateUsername(RegisteruserName) == false)
            {
                mUser = "User already exist \n";
            }
            if (UserManager.ValidatePassword(Registerpassword) == false)
            {
                mPassword = "Password need to be longer than 5 signs\n";
            }
            if (UserManager.ValidateCountry(RegisterCountry) == false)
            {
                mCountry = "You need to select a country";
            }

            if (UserManager.ValidateUsername(RegisteruserName) == false || UserManager.ValidatePassword(Registerpassword) == false || UserManager.ValidateCountry(RegisterCountry) == false)
            {
                MessageBox.Show(mUser + mPassword + mCountry, "Warning");
            }
            else
            {
                UserManager.AddUser(RegisteruserName, Registerpassword, RegisterCountry);
                MessageBox.Show("Welcome to TravelPal!", "Registration successful");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();

            }

        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            main.Show();
            Close();

        }
    }
}
