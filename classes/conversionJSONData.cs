using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Exchange.classes
{
    public static class conversionJSONData
    {
        //public static ObservableCollection<Model> CarList { get; set; } = new ObservableCollection<Model>();

        private static readonly string BaseDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CarExchangeDATA  ");


        static conversionJSONData()
        {
            if (!Directory.Exists(BaseDirectory))
            {
                Directory.CreateDirectory(BaseDirectory);
            }
        }

        public static void SaveCarToFile(Model car)
        {
            string filePath = Path.Combine(BaseDirectory, $"{car.VIN}.json");

            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static Model LoadCarFromFile(string vin)
        {
            string filePath = Path.Combine(BaseDirectory, $"{vin}.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File for VIN {vin} not found.");
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Model>(json);
        }
    }
}
