using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Input;

namespace Car_Exchange.xaml
{
    public partial class DodawanieSamochodu : Window
    {
        public string destinationFilePath;
        public DateTime thisDay = DateTime.Today;

        //TODO: przekazywanie danych do okna głównego
        public ObservableCollection<Model> CarList2 { get; set; } = new ObservableCollection<Model>();

        public DodawanieSamochodu()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void DodajSamochod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Marka = MarkaTextBox.Text;
                string modelS = ModelSamochoduTextBox.Text;
                int rokProdukcji = Convert.ToInt32(RokProdukcjiTextBox.Text);
                string kolorS = KolorTextBox.Text;
                double predkoscMax = Convert.ToDouble(PredkoscMaksymalnaTextBox.Text);
                double cenaS = Convert.ToDouble(CenaTextBox.Text);
                string lokalizacjaS = LokalizacjaTextBox.Text;
                DateTime dataDodaniaS = thisDay;
                CarList2.Add(new Model(Marka, modelS, rokProdukcji, kolorS, predkoscMax, cenaS, destinationFilePath, lokalizacjaS, dataDodaniaS));
                MessageBox.Show(CarList2[0].Informacje());
            } catch (Exception ex)
            {
                MessageBox.Show("Wprowadź wszystkie dane");
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
