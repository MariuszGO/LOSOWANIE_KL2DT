using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Program1
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
            int z1, z2,tmp;



            // z1 = Convert.ToInt32(zakres1.Text);
            // z2 = Convert.ToInt32(zakres2.Text);


            if (Int32.TryParse(zakres1.Text, out z1) && Int32.TryParse(zakres2.Text, out z2))
            {



                Random los = new Random();

                if (z2 < z1)
                {
                    wynik.Content = los.Next(z2, z1);
                }
                else
                {

                    wynik.Content = los.Next(z1, z2);
                }

            }
            else
            {
                MessageBox.Show("Podałeś tekst zamiast liczb", "Błąd");
            }
            }
    }
}