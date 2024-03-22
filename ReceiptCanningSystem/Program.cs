using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReceiptCanningSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // JSON dosyasının yolu
            string jsonFilePath = "response.json";
            // JSON dosyasını oku
            string jsonContent = File.ReadAllText(jsonFilePath);

            // JSON içeriğini JArray'e parse et
            JArray jsonArray = JArray.Parse(jsonContent);

            // İlk fişi al
            var firstFis = jsonArray.First;

            // İlk fişin açıklamasını ve koordinatlarını al
            string description = firstFis["description"].ToString();
            JObject coordinates = (JObject)firstFis["boundingPoly"];

            // Fişin başlangıç koordinatlarını al
            int x = coordinates["vertices"][0]["x"].Value<int>();
            int y = coordinates["vertices"][0]["y"].Value<int>();

            // Fiş metnini satır satır yazdır
            Console.WriteLine("AMAÇLANAN ÇIKTI");
            string[] lines = description.Split('\n');
            int lineNumber = 1;
            foreach (var line in lines)
            {
                Console.WriteLine($"{lineNumber++} {line.Trim()}");
            }

            Console.ReadLine();
        }
    }
}
