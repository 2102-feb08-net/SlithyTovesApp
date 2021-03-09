using System.Collections.Generic;
using System.Linq;
using Project1.BL;
using static Project1.BL.OrderDetailDTO;


namespace Project1.Data
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly Project1Context _context;

        public OrderDetailRepository(Project1Context context)
        {
            _context = context;
        }
        
        public OrderDetailDTO GetOrderDetailsByOrderId(int id)
        {
            OrderDetailDTO result = new OrderDetailDTO();
            result.Products = new List<ProductInfo>();
            var deets = _context.OrderDetails.Where(o => o.OrderId == id).ToList();

            foreach (var details in deets) {
                Product productByProductId = _context.Products.First(p => p.ProductId == details.ProductId);
                Order orderByOrderId = _context.Orders.First(o => o.OrderId == details.OrderId);
                result.OrderId = id;
                result.OrderDate = orderByOrderId.OrderDate;
                result.Subtotal = orderByOrderId.Subtotal;
                result.CustomerId = orderByOrderId.CustomerId;
                result.Products.Insert(0, new ProductInfo(productByProductId.ProductId, details.Quantity, productByProductId.ProductName, productByProductId.UnitPrice));
            }
            return result;
        }
    }
}