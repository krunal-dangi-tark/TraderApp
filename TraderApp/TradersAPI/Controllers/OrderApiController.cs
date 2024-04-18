using Microsoft.AspNetCore.Mvc;
using TraderApp;
using static TraderApp.Enum;

namespace TradersAPI.Controllers
{
    [Route("order")]
    public class OrderApiController: ControllerBase
    {
        private readonly OrderService orderService;

        public OrderApiController()
        {
            this.orderService = new OrderService();
        }

        [HttpPost]
        public void PlaceOrder([FromBody] OrderDTO orderDTO)
        {
            OrderType orderType =  orderDTO.OrderType == OrderType.Buy.ToString() ? OrderType.Buy : OrderType.Sell;
            orderService.PlaceOrder(orderDTO.Username, orderDTO.StockName, orderType, orderDTO.OrderPrice);
        }
    }
}
