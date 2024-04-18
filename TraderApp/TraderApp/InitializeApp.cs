namespace TraderApp
{
    public static class InitializeApp
    {
        public static void Init() { 
            RegisterUsers();
            RegisterStocks();
        }
        private static void RegisterUsers()
        {
            UserRegistry.AddUser(new Entities.User()
            {
                Name = "Chirag",
                Stocks = new List<Entities.Stock>()
            });
            UserRegistry.AddUser(new Entities.User()
            {
                Name = "Krunal",
                Stocks = new List<Entities.Stock>()
            });
        }

        private static void RegisterStocks()
        {
            StockRegistry.AddStock(new Entities.Stock()
            {
                Name = "Test1",
                CurrentPrice = 100
            });
            StockRegistry.AddStock(new Entities.Stock()
            {
                Name = "Test2",
                CurrentPrice = 200
            });
        }
    }
}