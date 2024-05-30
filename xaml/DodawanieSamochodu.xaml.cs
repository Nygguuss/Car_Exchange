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
                string marka = MarkaTextBox.Text;
                string modelS = ModelSamochoduTextBox.Text;
                int rokProdukcji = Convert.ToInt32(RokProdukcjiTextBox.Text);
                string kolor = KolorTextBox.Text;
                double predkosc = Convert.ToDouble(PredkoscMaksymalnaTextBox.Text);
                double cena = Convert.ToDouble(CenaTextBox.Text);
                string sciezkaDoZdjecia = imgSrc.Text;
                string lokalizacja = LokalizacjaTextBox.Text;
                DateTime dataDodania = DateTime.Today;
                string vin = VINTextbox.Text;
                int przebieg = Convert.ToInt32(PrzebiegTextbox.Text);
                RodzajSilnika rodzajSilnika = (RodzajSilnika)ComboBoxRodzajSilnika.SelectedItem;
                WersjaSilnika wersjaSilnika = (WersjaSilnika)ComboBoxWersjaSilnika.SelectedItem;
                int mocSilnika = Convert.ToInt32(MocSilnikaTextBox.Text);
                string rodzajSkrzyniBiegow = RodzajSkrzyniBiegowTextBox.Text;
                string numerRejestracyjny = NumerRejestracyjnyTextBox.Text;
                StanPojazdu stanPojazdu = (StanPojazdu)ComboBoxStanPojazdu.SelectedItem;
                bool czyBezwypadkowy = Convert.ToBoolean(CzyBezwypadkowyTextBox.Text);
                string rodzajOferty = RodzajOfertyTextBox.Text;
                string opis = OpisTextBox.Text;
                string numerSprzedajacego = NumerSprzedajacegoTextBox.Text;
                double srednieSpalanie = Convert.ToDouble(SrednieSpalanieTextBox.Text);
                EmisjaSpalania rodzajEmisjiSpalania = (EmisjaSpalania)ComboBoxEmisjaSpalania.SelectedItem;

                // Tworzymy nowy obiekt samochodu
                Model newCar = new Model(marka, modelS, rokProdukcji, kolor, predkosc, cena, sciezkaDoZdjecia, lokalizacja, dataDodania, vin, przebieg,
                                       rodzajSilnika, wersjaSilnika, mocSilnika, rodzajSkrzyniBiegow, numerRejestracyjny, stanPojazdu, czyBezwypadkowy,
                                       rodzajOferty, opis, numerSprzedajacego, srednieSpalanie, rodzajEmisjiSpalania);

                // Dodajemy samochód do listy
                Cars.CarList.Add(newCar);
                MessageBox.Show("Samochód został pomyślnie dodany i zapisany.");

            } catch (Exception ex)
            {
                MessageBox.Show($"Błąd wprowadzania danych. Sprawdź poprawność danych");
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
                string destinationPath = "C:\\Users\\Wuaje23\\source\\repos\\Nygguuss\\Car_Exchange\\src";
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
