using System;
using System.ComponentModel.DataAnnotations;

namespace Project1.BL
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Subtotal { get; set; }


        public Order()
        {
        }

        public Order(int orderId, int customerId, int storeId, DateTime orderDate, decimal subtotal) 
        {
            OrderId = orderId;
            CustomerId = customerId;
            StoreId = storeId;
            OrderDate = orderDate;
            Subtotal = subtotal;
        }
    }
}