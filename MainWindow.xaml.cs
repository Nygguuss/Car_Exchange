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
using System.Collections.ObjectModel;
using Car_Exchange.xaml;
using Car_Exchange.classes;

namespace Car_Exchange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Model wybranySamochod = (Model)samochodListbox.SelectedItem;
            DetaleSamochodu detaleSamochodu = new DetaleSamochodu(wybranySamochod);
            detaleSamochodu.Show();
            this.Close();
        }

        private void formularzDodawania_Click(object sender, RoutedEventArgs e)
        {
            DodawanieSamochodu dodawanieSamochodu = new DodawanieSamochodu();
            dodawanieSamochodu.Show();
            this.Close();
        }
    }
}
