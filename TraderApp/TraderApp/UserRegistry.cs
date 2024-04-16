using TraderApp.Entities;

namespace TraderApp
{
    internal static class UserRegistry
    {
        private static readonly List<User> users = new List<User>();
        public static List<User> GetUserByName(string name) => users.Where(x => x.Name.Equals(name)).ToList();
        public static void RemoveStock(string username, Stock stock) => users.FirstOrDefault(x => x.Name.Equals(username))?.Stocks?.Remove(stock);
        public static void AddStock(string username, Stock stock) => users.FirstOrDefault(x => x.Name.Equals(username))?.Stocks?.Add(stock);
        public static void AddUser(User user) => users.Add(user);
    }
}
