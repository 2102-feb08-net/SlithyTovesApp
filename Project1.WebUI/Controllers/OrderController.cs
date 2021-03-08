using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project1.BL;


namespace Project1.WebUI.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpPost("neworder")]
        public void CreateOrder(BL.Order order)
        {
            _orderRepository.CreateOrder(order);
        }

        [HttpGet("ordersbycustomerid/{customerid}")]
        public List<BL.Order> GetOrderByCustomerId(int id)
        {
            return _orderRepository.GetOrdersByCustomerId(id);
        }

        [HttpGet("orderbyorderid/{id}")]
        public BL.Order GetOrderByOrderId(int id)
        {
            return _orderRepository.GetOrderByOrderId(id);
        }

        [HttpGet("ordersbystoreid/{id}")]
        public List<BL.Order> GetOrdersByStoreId(int id)
        {
            return _orderRepository.GetOrdersByStoreId(id);
        }
    }
}