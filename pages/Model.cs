using System;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace Car_Exchange
{
    public class Model
    {
        public string Marka { get; set; }
        public string ModelSamochodu { get; set; }
        public int RokProdukcji { get; set; }
        public string Kolor { get; set; }
        public double PredkoscMaksymalna { get; set; }
        public string SciezkaDoZdjecia { get; set; }

        public Model(string marka, string modelS, int rokProdukcji, string kolor, double predkosc, string sciezkaDoZdjecia)
        {
            Marka = marka;
            ModelSamochodu = modelS;
            RokProdukcji = rokProdukcji;
            Kolor = kolor;
            PredkoscMaksymalna = predkosc;
            SciezkaDoZdjecia = sciezkaDoZdjecia;
        }

        public string Informacje()
        {
            return $"Marka: {Marka}, Model: {ModelSamochodu}, Rok produkcji: {RokProdukcji}, Kolor: {Kolor}, Prędkość: {PredkoscMaksymalna} km/h";
        }
    }
}
