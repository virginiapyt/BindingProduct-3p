using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingProduct_3p
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product pr1 = new Product("ax111", "klawiatura", 15, "glowny");
        public MainWindow()
        {
            InitializeComponent();

            //Product pr1 = new Product("ax111", "klawiatura", 15, "glowny");

            GridProducts.DataContext = pr1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tekst =
                String.Format("{0}{1}{2}", "Wprowadzono dane:",
                                            Environment.NewLine, pr1.ToString());
            MessageBox.Show(tekst,"produkt",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now; // Odczytanie bieżącej daty
            btn_czas.Content = data.ToString("f");
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_czas.Content = "Godzina";
        }
    }
}
