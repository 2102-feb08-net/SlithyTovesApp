using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.BL;


namespace Project1.WebUI.Controllers
{
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly Project1.BL.IOrderDetailRepository _orderDetailRepository;

        public OrderDetailController(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        [HttpGet("orderdetailsbyorderid/{id}")]
        public OrderDetailDTO GetOrderDetailsByOrderId(int id)
        {
            return _orderDetailRepository.GetOrderDetailsByOrderId(id);
        }
    }
}