using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.BL.Models
{
    class Inventory
    {
        public int StoreId { get; private set; }
        public int ProductId { get; set; }
        public int OnHand { get; set; }

        public Inventory()
        {
        }

        public Inventory(int storeId, int productId, int onHand)
        {
            StoreId = storeId;
            ProductId = productId;
            OnHand = onHand;
        }
    }
}
