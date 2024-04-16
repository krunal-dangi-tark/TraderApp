using TraderApp.Entities;

namespace TraderApp
{
    internal class StockRegistry
    {
        private static readonly List<Stock> stocks = new List<Stock>();

        public Stock? GetStockByName(string stockName) => stocks.FirstOrDefault(x => x.Name.Equals(stockName)); 
        public void AddStock(Stock stock) => stocks.Add(stock);
    }
}