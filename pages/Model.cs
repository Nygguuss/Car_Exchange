using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Car_Exchange
{
    public class Model : INotifyPropertyChanged
    {
        public string Marka { get; set; }
        public string ModelSamochodu { get; set; }
        public int RokProdukcji { get; set; }
        public string Kolor { get; set; }
        public double PredkoscMaksymalna { get; set; }
        public string Zdjecie { get; set; }
        public double Cena { get; set; }
        public string Lokalizacja { get; set; } 
        public DateTime DataDodania { get; set; }
        public string _imagePath { get; set; }

        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                NotifyPropertyChanged("ImageSource");
            }
        }

        public ImageSource ImageSource
        {
            get
            {
                return new BitmapImage(new Uri($"pack://application:,,,/Car_Exchange;component/{ImagePath}", UriKind.Absolute));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Model(string marka, string modelS, int rokProdukcji, string kolor, double predkosc, double c, string sciezkaDoZdjecia, string lokalizacja, DateTime dataDodania)
        {
            Marka = marka;
            ModelSamochodu = modelS;
            RokProdukcji = rokProdukcji;
            Kolor = kolor;
            PredkoscMaksymalna = predkosc;
            Cena = c;
            Zdjecie = sciezkaDoZdjecia;
            Lokalizacja = lokalizacja; 
            DataDodania = dataDodania;
            ImagePath = sciezkaDoZdjecia;
        }

        public string Informacje()
        {
            return $"Marka: {Marka}, Model: {ModelSamochodu}, Rok produkcji: {RokProdukcji}, Kolor: {Kolor}, Prędkość: {PredkoscMaksymalna} km/h, Cena: {Cena}, Lokalizacja: {Lokalizacja}, Data dodania: {DataDodania}";
        }
    }
}
