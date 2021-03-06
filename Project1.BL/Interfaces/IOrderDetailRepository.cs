using System.Collections.Generic;


namespace Project1.BL
{
    public interface IOrderDetailRepository
    {        
        BL.OrderDetail GetOrderDetailsByOrderId(int id);
    }
}