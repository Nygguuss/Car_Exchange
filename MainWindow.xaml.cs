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

namespace Car_Exchange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Model> carList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            carInit();
        }

        public void carInit()
        {
            carList = new List<Model>();

            Model car1 = new Model("Opel", "Corsa", 2016, "Szary", 220, 85000, "src\\auto.png", "Warszawa", new DateTime(2022, 4, 12));
            Model car2 = new Model("Dacia", "Sandero", 2012, "Niebieski", 220, 33000, "src\\auto2.png", "Kraków", new DateTime(2022, 4, 11));
            Model car3 = new Model("Ford", "Mk3", 2017, "Czerwony", 280, 127000, "src\\auto3.png", "Gdańsk", new DateTime(2022, 4, 10));
            Model car4 = new Model("Scania", "R730", 2015, "Brązowy", 180, 750000, "src\\auto4.png", "Poznań", new DateTime(2022, 4, 9));

            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);
            this.DataContext = carList;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Siema");
        }
    }
}
