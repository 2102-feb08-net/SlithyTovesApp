using System.Collections.Generic;


namespace Project1.BL
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        List<BL.Order> GetOrdersByStoreId(int id);
        
        BL.Order GetOrderByOrderId(int id);

        List<BL.Order> GetOrdersByCustomerId(int id);
    }
}