using System;
using Project1.BL;
using System.Collections.Generic;
using System.Linq;
using static Project1.BL.OrderDetailDTO;



namespace Project1.Data
{
    public class OrderRepository : IOrderRepository
    {

        private readonly Project1Context _context;

        public OrderRepository(Project1Context context)
        {
            _context = context;
        }

        public void CreateOrder(OrderDetailDTO order)
        {

            Order orderToCreate = new Order()
            {
                CustomerId = order.CustomerId,
                StoreId = order.StoreId,
                OrderDate = DateTime.Now,
                Subtotal = order.Subtotal
            };

            _context.Add(orderToCreate);
            _context.SaveChanges();

            Order justCreated = _context.Orders.OrderBy(x => x.OrderId).Last();
            var deetsOfJustCreated = _context.OrderDetails.OrderBy(x => x.OrderId).Last();

            List<OrderDetail> listOfDeets = new List<OrderDetail>();

            foreach (var item in order.Products)
            {
                var moreInfo = new OrderDetail
                {
                    OrderId = justCreated.OrderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };
                listOfDeets.Add(moreInfo);
            }

            foreach (var deet in listOfDeets)
            {
                _context.Add(deet);
                _context.SaveChanges();
            }

            // update inventory

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