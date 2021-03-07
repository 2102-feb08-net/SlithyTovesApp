using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.BL;
using Project1.Data;

namespace Project1.Data
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly Project1Context _context;

        public OrderDetailRepository(Project1Context context)
        {
            _context = context;
        }
        public BL.OrderDetail GetOrderDetailsByOrderId(int id)
        {
            var deets = _context.OrderDetails.Where(o => o.OrderId == id).First();
            BL.OrderDetail searched = new BL.OrderDetail(deets.OrderId, deets.ProductId, deets.Quantity);
            return searched;
        }
    }
}