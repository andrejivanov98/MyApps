using System;
using System.Net.Http;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace SupermarketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://interview-task-api.mca.dev/qr-scanner-codes/alpha-qr-gFpwhsQ8fkY1";
            string jsonString = string.Empty;

            using (HttpClient client = new HttpClient()) 
            {
                HttpResponseMessage message = client.GetAsync(url).Result; 
                if(message.StatusCode == HttpStatusCode.OK) 
                {
                    jsonString = message.Content.ReadAsStringAsync().Result; 
                }
                else
                {
                    Console.WriteLine($"{message.StatusCode}");
                    return;
                }
            }
            List<Fruit> fruitsList = JsonConvert.DeserializeObject<List<Fruit>>(jsonString); // fruitList = null

            try {
                DbFruits.Domesctic = fruitsList.Where(x => x.Domestic).ToList().OrderBy(x => x.Name).ToList();
                DbFruits.Imported = fruitsList.Where(x => !x.Domestic).ToList().OrderBy(x => x.Name).ToList();

                DbFruits.TotalDomesticPrice = DbFruits.Domesctic.Sum(x => x.Price);
                DbFruits.TotalImportedPrice = DbFruits.Imported.Sum(x => x.Price);

                Console.WriteLine(" . Domestic");
                foreach (Fruit fruit in DbFruits.Domesctic)
                {
                    Console.WriteLine(fruit.PrintFruit());
                }
                Console.WriteLine(" . Imported");
                foreach (Fruit fruit in DbFruits.Imported)
                {
                    Console.WriteLine(fruit.PrintFruit());
                }

                Console.WriteLine($"Domestic cost: ${DbFruits.TotalDomesticPrice}");
                Console.WriteLine($"Imported cost: ${DbFruits.TotalImportedPrice}");

                Console.WriteLine($"Domestic count: {DbFruits.Domesctic.Count}");
                Console.WriteLine($"Imported count: {DbFruits.Imported.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }
    }
}
