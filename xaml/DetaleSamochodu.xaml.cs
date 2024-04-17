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
using System.Windows.Shapes;

namespace Car_Exchange.xaml
{
    /// <summary>
    /// Interaction logic for DetaleSamochodu.xaml
    /// </summary>
    public partial class DetaleSamochodu : Window
    {
        Model model;
        public DetaleSamochodu(Model wybranySamochod)
        {
            InitializeComponent();
            model = wybranySamochod;
            DataContext = model;
        }

        private void Cofanie_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
