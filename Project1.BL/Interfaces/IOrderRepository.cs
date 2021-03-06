using System.Collections.Generic;


namespace Project1.BL
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        List<BL.Order> GetOrdersByLocationId(int id);

        List<BL.Order> GetOrdersByCustomerId(int id);
    }
}