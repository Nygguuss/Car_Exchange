using System;

namespace Car_Exchange
{
    public class Model
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
        }

        public string Informacje()
        {
            return $"Marka: {Marka}, Model: {ModelSamochodu}, Rok produkcji: {RokProdukcji}, Kolor: {Kolor}, Prędkość: {PredkoscMaksymalna} km/h, Cena: {Cena}, Lokalizacja: {Lokalizacja}, Data dodania: {DataDodania}";
        }
    }
}
