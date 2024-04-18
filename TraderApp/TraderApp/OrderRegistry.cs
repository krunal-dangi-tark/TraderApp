using TraderApp.Entities;

namespace TraderApp
{
    internal static class OrderRegistry
    {
        private static readonly List<TradeOrder> tradeOrders = new List<TradeOrder>();
        public static List<TradeOrder> GetOrderByType(Enum.OrderType orderType) => tradeOrders.Where(x => x.OrderType.Equals(orderType)).ToList();
        public static void PlaceOrder(TradeOrder order) => tradeOrders.Add(order);
        public static void RemoveOrder(TradeOrder order) => tradeOrders.Remove(order);
    }
}