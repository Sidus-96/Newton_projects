using GreenThumb.Database;
using GreenThumb.Manager;
using System.Windows;

namespace GreenThumb
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPasswordSignIn.Password;

            using (GreenThumbDbContext context = new())
            {
                var user = context.User.FirstOrDefault(u => u.Username == username && u.Password == password); //Kontrollera så att lösenordet och användarnamnet är korrekt innan inloggning
                if (user != null)
                {
                    UserManager.setUserId(user.Id);
                    PlantWindow plantwindow = new PlantWindow();
                    plantwindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Warning");
                }
            }
        }
        private void btnRegisterWindow_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }
    }
}