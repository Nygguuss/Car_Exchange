using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Input;
using Car_Exchange.classes;
using System.Diagnostics;

namespace Car_Exchange.xaml
{
    public partial class DodawanieSamochodu : Window
    {
        public string destinationFilePath;
        public DateTime thisDay = DateTime.Today;
        //kolekcje
        public ObservableCollection<RodzajSilnika> RodzajeSilnikow { get; } = new ObservableCollection<RodzajSilnika>(Enum.GetValues(typeof(RodzajSilnika)).Cast<RodzajSilnika>());
        public ObservableCollection<WersjaSilnika> WersjeSilnikow { get; } = new ObservableCollection<WersjaSilnika>(Enum.GetValues(typeof(WersjaSilnika)).Cast<WersjaSilnika>());
        public ObservableCollection<EmisjaSpalania> RodzajeEmisjiSpalania { get; } = new ObservableCollection<EmisjaSpalania>(Enum.GetValues(typeof(EmisjaSpalania)).Cast<EmisjaSpalania>());
        public ObservableCollection<StanPojazdu> StanyPojazdow { get; } = new ObservableCollection<StanPojazdu>(Enum.GetValues(typeof(StanPojazdu)).Cast<StanPojazdu>());


        public DodawanieSamochodu()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void DodajSamochod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //TODO: Dodawanie samochodu
                /*
                string Marka = MarkaTextBox.Text;
                string modelS = ModelSamochoduTextBox.Text;
                int rokProdukcji = Convert.ToInt32(RokProdukcjiTextBox.Text);
                string kolorS = KolorTextBox.Text;
                double predkoscMax = Convert.ToDouble(PredkoscMaksymalnaTextBox.Text);
                double cenaS = Convert.ToDouble(CenaTextBox.Text);
                string lokalizacjaS = LokalizacjaTextBox.Text;
                DateTime dataDodaniaS = thisDay;
                //Cars.CarList.Add(new Model(Marka, modelS, rokProdukcji, kolorS, predkoscMax, cenaS, destinationFilePath, lokalizacjaS, dataDodaniaS));
                */
            } catch (Exception ex)
            {
                MessageBox.Show($"Błąd wprowadzania danych {ex}");
            }
        }

        private void DodajZdjecie_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == true)
            {
                // Wczytaj zdjęcie
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();

                // Wyświetl zdjęcie
                DisplayedImage.Source = bitmap;

                // Zapisz zdjęcie
                //TODO: ustawić path w obrębie projektu a nie na sztywno!!!!
                string destinationPath = "C:\\Users\\ADMIN\\source\\repos\\Car_Exchange\\src"; // Ustaw docelową ścieżkę
                string fileName = Path.GetFileName(openFileDialog.FileName);
                destinationFilePath = Path.Combine(destinationPath, fileName);
                imgSrc.Text = destinationFilePath;
                File.Copy(openFileDialog.FileName, destinationFilePath, true);
            }
        }

        private void Cofanie_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
