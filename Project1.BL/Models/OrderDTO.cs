using System;
using System.Collections.Generic;

namespace Project1.BL
{
    public class OrderDetailDTO
    {
        public int OrderId { get; set; }
        public int CustomerId {get; set; }
        public DateTime OrderDate { get; set; }
        public decimal SubTotal { get; set; }

        public List<ProductInfo> Products { get; set; }

        public class ProductInfo 
        {
            public int ProductId {get; set;}
            public int Quantity {get; set;}
            public string ProductName {get; set;}
            public decimal UnitPrice {get; set;}

            public ProductInfo(int productId, int quantity, string productName, decimal unitPrice) {
                ProductId = productId;
                Quantity = quantity;
                ProductName = productName;
                UnitPrice = unitPrice;
            }
            
            public static implicit operator List<object>(ProductInfo v)
            {
                throw new NotImplementedException();
            }
        }

        public OrderDetailDTO()
        {   
        }
    }
}