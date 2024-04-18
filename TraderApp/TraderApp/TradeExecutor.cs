using TraderApp.Entities;

namespace TraderApp
{
    internal class TradeExecutor
    {
        public TradeExecutor()
        {
            
        }
        public void MatchOrder(TradeOrder tradeOrder)
        {
            if (tradeOrder.OrderType == Enum.OrderType.Buy)
            {
                ExecuteBuyOrder(tradeOrder);
            }
            else
            {
                ExecuteSellOrder(tradeOrder);
            }
        }

        public void ExecuteSellOrder(TradeOrder tradeOrder)
        {
            var buyOrder = OrderRegistry.GetOrderByType(Enum.OrderType.Buy).FirstOrDefault(x => x.Price >= tradeOrder.Price && x.Stock.Name.Equals(tradeOrder.Stock.Name));
            if (buyOrder != null)
            {
                UserRegistry.RemoveStock(tradeOrder.User.Name, tradeOrder.Stock);
                UserRegistry.AddStock(buyOrder.User.Name, buyOrder.Stock);
                OrderRegistry.RemoveOrder(buyOrder);
            }
        }

        public void ExecuteBuyOrder(TradeOrder tradeOrder)
        {
            var sellOrder = OrderRegistry.GetOrderByType(Enum.OrderType.Sell).FirstOrDefault(x => x.Price <= tradeOrder.Price && x.Stock.Name.Equals(tradeOrder.Stock.Name));
            if (sellOrder != null)
            {
                UserRegistry.RemoveStock(sellOrder.User.Name, sellOrder.Stock);
                UserRegistry.AddStock(tradeOrder.User.Name, tradeOrder.Stock);
                OrderRegistry.RemoveOrder(sellOrder);
            }
        }
    }
}
