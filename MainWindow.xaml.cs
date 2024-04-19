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

namespace Car_Exchange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Model> CarList { get; set; } = new ObservableCollection<Model>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            InitializeCars();
            
        }

        private void InitializeCars()
        {
            CarList.Add(new Model("Opel", "Corsa", 2016, "Szary", 220, 85000, "src\\auto.png", "Warszawa", new DateTime(2022, 4, 12)));
            CarList.Add(new Model("Dacia", "Sandero", 2012, "Niebieski", 220, 33000, "src\\auto2.png", "Kraków", new DateTime(2022, 4, 11)));
            CarList.Add(new Model("Ford", "Mk3", 2017, "Czerwony", 280, 127000, "src\\auto3.png", "Gdańsk", new DateTime(2022, 4, 10)));
            CarList.Add(new Model("Scania", "R730", 2015, "Brązowy", 180, 750000, "src\\auto4.png", "Poznań", new DateTime(2022, 4, 9)));
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
