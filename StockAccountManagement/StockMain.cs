using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StockAccountManagement;

namespace StockAccountManagement
{
    public class StockMain
    {
        Model account = new Model();
        List<Model> accountList = new List<Model>();
        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("StockName NumOfShare SharePrice TotalValueOfStock");
                foreach (var item in items)
                {
                    double value = item.SharePrice * item.NumOfShare;
                    Console.WriteLine(item.StockName + " " + item.NumOfShare + " " + item.SharePrice + " " + value);
                }
            }
        }
    }
}