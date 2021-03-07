using System;

namespace Project1.BL
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a positive quantity.");
                }
            }
        }

        public OrderDetail()
        {   
        }

        public OrderDetail(int orderId, int productId, int quantity)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}