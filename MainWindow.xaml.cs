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

            Model car1 = new Model("Opel", "Corsa", 2016, "Szary", 220, "src\\auto.png");
            Model car2 = new Model("Dacia", "Sandero", 2012, "Niebieski", 220, "src\\auto2.png");
            Model car3 = new Model("Ford", "Mk3", 2017, "Czerwony", 280, "src\\auto3.png");
            Model car4 = new Model("Scania", "R730", 2015, "Brązowy", 180, "src\\auto4.png");

            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);
            this.DataContext = carList;
        }
    }
}
