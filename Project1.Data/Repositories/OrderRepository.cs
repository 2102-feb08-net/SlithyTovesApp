using Project1.BL;
using System.Collections.Generic;
using System.Linq;


namespace Project1.Data
{
    public class OrderRepository : IOrderRepository
    {

        private readonly Data.Project1Context _context;
            
        public OrderRepository(Project1Context context)
        {
            _context = context;
        }

        public void CreateOrder(BL.Order order)
        {
            BL.Order orderToCreate = new BL.Order() 
                { OrderId = order.OrderId, CustomerId = order.CustomerId, StoreId = order.StoreId, OrderDate = order.OrderDate, 
                    Subtotal = order.Subtotal };
            
            _context.Add(orderToCreate);
            _context.SaveChanges();
        }

        public List<BL.Order> GetOrdersByStoreId(int id)
        {
            var list = new List<BL.Order>();
            var results = _context.Set<Order>().Where(c => c.StoreId == id).ToList();

            foreach (var result in results)
            {
                list.Add(new BL.Order(result.OrderId, result.CustomerId, result.StoreId, result.OrderDate, result.Subtotal));
            }
           
            return list;
        }

        public BL.Order GetOrderByOrderId(int id)
        {
            var result = _context.Orders.Where(o => o.OrderId == id).First();
            BL.Order order = new BL.Order(result.OrderId, result.CustomerId, result.StoreId, result.OrderDate, result.Subtotal);
            return order;
        }

        public List<BL.Order> GetOrdersByCustomerId(int id)
        {
            var list = new List<BL.Order>();
            var results = _context.Set<Order>().Where(c => c.CustomerId == id).ToList();

            foreach (var result in results)
            {
                list.Add(new BL.Order(result.OrderId, result.CustomerId, result.StoreId, result.OrderDate, result.Subtotal));
            }
           
            return list;
        }
    }
}