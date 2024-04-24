using System;
using System.Collections.ObjectModel;

namespace Car_Exchange
{
    public static class Cars
    {
        public static ObservableCollection<Model> CarList { get; set; } = new ObservableCollection<Model>();

        private static bool wywolanoFunkcje = false;

        public static void DodajLosowySamochod()
        {
            if (!wywolanoFunkcje)
            {
                wywolanoFunkcje = true;

                Random random = new Random();
                string[] marki = { "Opel", "Dacia", "Ford", "Scania", "BMW", "Audi", "Volkswagen", "Toyota", "Mercedes-Benz", "Fiat" };
                string[] modele = { "Corsa", "Sandero", "Mk3", "R730", "3 Series", "A4", "Golf", "Corolla", "C-Class", "Punto" };
                string[] kolory = { "Czerwony", "Niebieski", "Zielony", "Żółty", "Czarny", "Biały", "Srebrny", "Pomarańczowy", "Fioletowy", "Brązowy" };
                string[] lokalizacje = { "Warszawa", "Kraków", "Gdańsk", "Poznań", "Łódź", "Wrocław", "Szczecin", "Katowice", "Bydgoszcz", "Lublin" };
                string[] rodzajeSkrzyniBiegow = { "Manualna", "Automatyczna", "Półautomatyczna" };
                string[] numeryRejestracyjne = { "ABC 12345", "XYZ 54321", "DEF 98765", "GHI 24680", "JKL 13579" };
                string[] rodzajeOferty = { "Sprzedaż", "Wynajem", "Leasing" };
                string[] opisy = { "Samochód w bardzo dobrym stanie", "Tylko jeden właściciel", "Bezwypadkowy", "Regularnie serwisowany" };
                string[] numerySprzedajacego = { "123456789", "987654321", "555555555", "111111111", "999999999" };

                Model losowyModel = new Model(
                    marki[random.Next(marki.Length)],
                    modele[random.Next(modele.Length)],
                    random.Next(2000, 2023), // Rok produkcji losowany od 2000 do 2022
                    kolory[random.Next(kolory.Length)],
                    random.Next(180, 301), // Prędkość maksymalna losowana od 180 do 300 km/h
                    random.Next(30000, 300001), // Cena losowana od 30000 do 300000 PLN
                    "C:\\Users\\Wuaje23\\Source\\Repos\\Nygguuss\\Car_Exchange\\src\\auto2.png", // Tutaj możesz wprowadzić losową ścieżkę do zdjęcia
                    lokalizacje[random.Next(lokalizacje.Length)],
                    new DateTime(random.Next(2000, 2023), random.Next(1, 13), random.Next(1, 29)), // Losowa data dodania
                    $"VIN{random.Next(100000000, 1000000000)}", // Losowy numer VIN
                    random.Next(0, 250000), // Losowy przebieg od 0 do 250000 km
                    (RodzajSilnika)random.Next(Enum.GetNames(typeof(RodzajSilnika)).Length), // Losowy rodzaj silnika
                    (WersjaSilnika)random.Next(Enum.GetNames(typeof(WersjaSilnika)).Length), // Losowa wersja silnika
                    random.Next(50, 500), // Losowa moc silnika od 50 do 500 KM
                    rodzajeSkrzyniBiegow[random.Next(rodzajeSkrzyniBiegow.Length)],
                    numeryRejestracyjne[random.Next(numeryRejestracyjne.Length)],
                    (StanPojazdu)random.Next(Enum.GetNames(typeof(StanPojazdu)).Length), // Losowy stan pojazdu
                    random.Next(2) == 1, // Losowe czy bezwypadkowy
                    rodzajeOferty[random.Next(rodzajeOferty.Length)],
                    opisy[random.Next(opisy.Length)],
                    numerySprzedajacego[random.Next(numerySprzedajacego.Length)],
                    random.Next(4, 10) + random.NextDouble(), // Losowe średnie spalanie od 4 do 10 l/100km
                    (EmisjaSpalania)random.Next(Enum.GetNames(typeof(EmisjaSpalania)).Length) // Losowy rodzaj emisji spalania
                );

                Cars.CarList.Add(losowyModel);

            }
        }
    }
}
//stare wersje obietków
//new Model("Opel", "Corsa", 2016, "Szary", 220, 85000, "src\\auto.png", "Warszawa", new DateTime(2022, 4, 12)),
//new Model("Dacia", "Sandero", 2012, "Niebieski", 220, 33000, "src\\auto2.png", "Kraków", new DateTime(2022, 4, 11)),
//new Model("Ford", "Mk3", 2017, "Czerwony", 280, 127000, "src\\auto3.png", "Gdańsk", new DateTime(2022, 4, 10)),
//new Model("Scania", "R730", 2015, "Brązowy", 180, 750000, "src\\auto4.png", "Poznań", new DateTime(2022, 4, 9))