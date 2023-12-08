using GreenThumb.Database;
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
            using (GreenThumbDbContext context = new())
            {
                //   var planta = context.Plants.First(p => p.Name == "Lilja");
                //   var plantinstru = context.Instructions.First(w => w.Name == "Lilja");
                // var plantWithInstructions = context.Plants.Include(w => w.Instructions).First(w => w.Id == 1);

            }

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
    }
}