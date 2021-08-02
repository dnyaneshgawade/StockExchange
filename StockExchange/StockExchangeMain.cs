using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StockExchange
{
    public class StockExchangeMain
    {
        public void DisplayData(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string jsonData = File.ReadAllText(filepath);
                    StockExchangeModel jsonObjectArray = JsonConvert.DeserializeObject<StockExchangeModel>(jsonData);
                    Console.WriteLine("\nPrice table for Rice\nName\t\tWeight\tPricePerKg\tAmount");
                    List<Stock> stocks = jsonObjectArray.StockList;
                    foreach (var item in stocks)
                    {
                        Console.WriteLine("{0}" + "\t\t" + "{1}" + "\t" + "{2}" + "\t\t" + "{3}", item.Name, item.Stocks, item.StockPrice, item.Stocks * item.StockPrice);
                    }
                }
                else
                {
                    Console.WriteLine("\nspecified path is not present");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
