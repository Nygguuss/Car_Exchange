using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Exchange
{
    public static class Cars
    {
        public static ObservableCollection<Model> CarList { get; set; } = new ObservableCollection<Model>()
        {
            new Model("Opel", "Corsa", 2016, "Szary", 220, 85000, "src\\auto.png", "Warszawa", new DateTime(2022, 4, 12)),
            new Model("Dacia", "Sandero", 2012, "Niebieski", 220, 33000, "src\\auto2.png", "Kraków", new DateTime(2022, 4, 11)),
            new Model("Ford", "Mk3", 2017, "Czerwony", 280, 127000, "src\\auto3.png", "Gdańsk", new DateTime(2022, 4, 10)),
            new Model("Scania", "R730", 2015, "Brązowy", 180, 750000, "src\\auto4.png", "Poznań", new DateTime(2022, 4, 9))
        };

    }
}
