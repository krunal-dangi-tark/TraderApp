using static TraderApp.Enum;

namespace TraderApp.Entities
{
    internal class TradeOrder
    {
        public User User { get; set; }
        public Stock Stock { get; set; }
        public OrderType OrderType { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Price { get; set; }
    }
}