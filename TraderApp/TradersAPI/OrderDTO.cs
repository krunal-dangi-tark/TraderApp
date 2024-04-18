namespace TradersAPI
{
    public class OrderDTO
    {
        public string Username { get; set; }
        public string StockName { get; set; }
        public decimal OrderPrice { get; set; }
        public string OrderType { get; set; }
    }
}
