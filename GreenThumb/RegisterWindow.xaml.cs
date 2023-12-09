using GreenThumb.Database;
using GreenThumb.Models;
using System.Windows;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (txtRegisterUsername.ToString() != "" || txtRegisterPassword.ToString() != "")
            {
                string username = txtRegisterUsername.Text;
                string password = txtRegisterPassword.Password;

                using (GreenThumbDbContext context = new())
                {
                    bool checkUserExist = context.User.Where(u => u.Username == username).Any();
                    if (checkUserExist)
                    {
                        MessageBox.Show("User already exist");
                    }
                    else
                    {
                        UserModel newUser = new()
                        {
                            Username = username,
                            Password = password
                        };
                        context.User.Add(newUser);

                        context.SaveChanges();

                        GardenRepository gardenRepository = new(context);


                        GardenModel newgarden = new GardenModel();

                        newgarden.UserId = newUser.Id;

                        gardenRepository.Add(newgarden);



                        context.SaveChanges();
                        MessageBox.Show("Welcome", "Success");
                        MainWindow mainWindow = new MainWindow(); //Få tillbaka användaren efter uppskapande av konto
                        mainWindow.Show();
                        Close();

                    }


                }
            }
            else
            {
                MessageBox.Show("Invalid username or Password");
            }
        }


    }
}
