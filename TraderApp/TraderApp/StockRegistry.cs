using TraderApp.Entities;

namespace TraderApp
{
    internal static class StockRegistry
    {
        private static readonly List<Stock> stocks = new List<Stock>();

        public static Stock? GetStockByName(string stockName) => stocks.FirstOrDefault(x => x.Name.Equals(stockName)); 
        public static void AddStock(Stock stock) => stocks.Add(stock);
    }
}