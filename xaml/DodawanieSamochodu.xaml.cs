using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Car_Exchange.xaml
{
    /// <summary>
    /// Interaction logic for DodawanieSamochodu.xaml
    /// </summary>
    public partial class DodawanieSamochodu : Window
    {

        public ObservableCollection<Model> CarList2 { get; set; } = new ObservableCollection<Model>();
        public DodawanieSamochodu()
        {
            InitializeComponent();
        }

        private void DodajSamochod_Click(object sender, RoutedEventArgs e)
        {
            //CarList.Add(new Model("Opel", "Corsa", 2016, "Szary", 220, 85000, "src\\auto.png", "Warszawa", new DateTime(2022, 4, 12)));
            //CarList2.Add(new Model();
        }
    }
}
