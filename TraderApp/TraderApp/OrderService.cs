using TraderApp.Entities;

namespace TraderApp
{
    public class OrderService
    {
        private readonly TradeExecutor _tradeExecutor;
        public OrderService()
        {
            _tradeExecutor = new TradeExecutor();
        }

        public void PlaceOrder(string username, string stockName, Enum.OrderType orderType, decimal price)
        {
            User user = UserRegistry.GetUserByName(username);
            Stock stock = StockRegistry.GetStockByName(stockName);

            TradeOrder tradeOrder = new TradeOrder()
            {
                DateTime = DateTime.Now,
                OrderType = orderType,
                Price = price,
                Stock = stock,
                User = user
            };
            OrderRegistry.PlaceOrder(tradeOrder);
            _tradeExecutor.MatchOrder(tradeOrder);
        }
    }
}