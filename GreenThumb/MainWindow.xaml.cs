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
                var plantinstru = context.Instructions.First(w => w.Name == "Lilja");

                // var plantwithinstruc = context.Instructions.Include(w => w.plant).First(o => o.Name == "Lilja");
                var plantwithinstruc = context.Instructions.Where(o => o.Name == "Lilja").ToList(); //för att få fram alla instruktioner per växt

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