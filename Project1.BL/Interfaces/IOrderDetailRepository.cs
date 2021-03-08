using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project1.BL
{
    public interface IOrderDetailRepository
    {        
        BL.OrderDetailDTO GetOrderDetailsByOrderId(int id);
    }
}