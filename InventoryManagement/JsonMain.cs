using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class JsonMain
    {
        Model2 Inventory = new Model2();
        List<Model2> InventoryList = new List<Model2>();
        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("Name Weight Price TotalValue");
                foreach (var item in items)
                {
                    double value = item.Price * item.Weight;
                    Console.WriteLine(item.Name + " " + item.Weight + " " + item.Price + " " + value);
                }
            }
        }
    }
}
