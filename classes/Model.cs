using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Car_Exchange
{
    public enum EmisjaSpalania
    {
        Euro1,
        Euro2,
        Euro3,
        Euro4,
        Euro5,
        Euro6
    } 

    public enum StanPojazdu
    {
        Nowy,
        Uzywany,
        Uszkodzony
    }

    public enum RodzajSilnika
    {
        Benzyna,
        Diesel,
        Hybrydowy,
        Elektryczny
    }

    public enum WersjaSilnika
    {
        _1_0,
        _1_1,
        _1_2,
        _1_3,
        _1_4,
        _1_5,
        _1_6,
        _1_7,
        _1_8,
        _1_9,
        _2_0,
        _2_1,
        _2_2,
        _2_3,
        _2_4,
        _2_5,
        _2_6,
        _2_7,
        _2_8,
        _2_9,
        _3_0,
        _3_1,
        _3_2,
        _3_3,
        _3_4,
        _3_5,
        _3_6,
        _3_7,
        _3_8,
        _3_9,
        _4_0,
        _4_1,
        _4_2,
        _4_3,
        _4_4,
        _4_5,
        _4_6,
        _4_7,
        _4_8,
        _4_9,
        _5_0
    }

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
        public string VIN { get; set; }
        public int Przebieg { get; set; }
        public RodzajSilnika RodzajSilnika { get; set; }
        public WersjaSilnika WersjaSilnika { get; set; }
        public int MocSilnika { get; set; }
        public string RodzajSkrzyniBiegow { get; set; }
        public string NumerRejestracyjny { get; set; }
        public StanPojazdu StanPojazdu { get; set; }
        public bool CzyBezwypadkowy { get; set; }
        public string RodzajOferty { get; set; }
        public string Opis { get; set; } // Opis samochodu
        public string NumerSprzedajacego { get; set; } // Numer telefonu lub identyfikator sprzedającego
        public double SrednieSpalanie { get; set; } // Średnie spalanie w litrach na 100 km
        public EmisjaSpalania RodzajEmisjiSpalania { get; set; } // Rodzaj emisji spalania

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
        //TODO: wywala błąd kiedy próbuje się z dodanym samochodem wejść w detale, program wysypuje się tutaj i wskazuje że nie może znależć zdjecia
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

        public Model(string marka, string modelS, int rokProdukcji, string kolor, double predkosc, double c, string sciezkaDoZdjecia, string lokalizacja, DateTime dataDodania,
                     string vin, int przebieg, RodzajSilnika rodzajSilnika, WersjaSilnika wersjaSilnika, int mocSilnika, string rodzajSkrzyniBiegow, string numerRejestracyjny, StanPojazdu stanPojazdu, bool czyBezwypadkowy, string rodzajOferty,
                     string opis, string numerSprzedajacego, double srednieSpalanie, EmisjaSpalania rodzajEmisjiSpalania)
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
            VIN = vin;
            Przebieg = przebieg;
            RodzajSilnika = rodzajSilnika;
            WersjaSilnika = wersjaSilnika;
            MocSilnika = mocSilnika;
            RodzajSkrzyniBiegow = rodzajSkrzyniBiegow;
            NumerRejestracyjny = numerRejestracyjny;
            StanPojazdu = stanPojazdu;
            CzyBezwypadkowy = czyBezwypadkowy;
            RodzajOferty = rodzajOferty;
            Opis = opis;
            NumerSprzedajacego = numerSprzedajacego;
            SrednieSpalanie = srednieSpalanie;
            RodzajEmisjiSpalania = rodzajEmisjiSpalania;
            ImagePath = sciezkaDoZdjecia;
        }

        public string Informacje()
        {
            return $"Marka: {Marka}, Model: {ModelSamochodu}, Rok produkcji: {RokProdukcji}, Kolor: {Kolor}, Prędkość: {PredkoscMaksymalna} km/h, Cena: {Cena}, " +
                   $"Lokalizacja: {Lokalizacja}, Data dodania: {DataDodania}, VIN: {VIN}, Przebieg: {Przebieg}, Rodzaj silnika: {RodzajSilnika}, Wersja silnika: {WersjaSilnika}, " +
                   $"Moc silnika: {MocSilnika}, Rodzaj skrzyni biegów: {RodzajSkrzyniBiegow}, Numer rejestracyjny: {NumerRejestracyjny}, Stan pojazdu: {StanPojazdu}, " +
                   $"Czy bezwypadkowy: {CzyBezwypadkowy}, Rodzaj oferty: {RodzajOferty}, Opis: {Opis}, Numer sprzedającego: {NumerSprzedajacego}, Średnie spalanie: {SrednieSpalanie} l/100km, " +
                   $"Rodzaj emisji spalania: {RodzajEmisjiSpalania}";
        }
    }
}
