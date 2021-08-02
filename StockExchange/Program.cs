using System;

namespace StockExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            const string INVENTORY_JSON = @"C:\Users\dnyan\dnyana\StockExchange\StockExchange\StockExchangejson\json1.json";
            StockExchangeMain stockExchangeMain = new StockExchangeMain();
            stockExchangeMain.DisplayData(INVENTORY_JSON);
        }
    }
    
}
