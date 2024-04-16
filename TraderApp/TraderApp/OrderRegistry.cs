using TraderApp.Entities;

namespace TraderApp
{
    internal class OrderRegistry
    {
        private static readonly List<TradeOrder> tradeOrders = new List<TradeOrder>();
        public List<TradeOrder> GetOrderByType(Enum.OrderType orderType) => tradeOrders.Where(x => x.OrderType.Equals(orderType)).ToList();
        public void PlaceOrder(TradeOrder order) => tradeOrders.Add(order);
    }
}