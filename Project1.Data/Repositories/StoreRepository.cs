using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.BL;
using Project1.Data;

namespace Project1.Data
{
    public class StoreRepository : IStoreRepository
    {
        private readonly Project1Context _context;
        public BL.Store GetStoreById(int id)
        {
            var store = _context.Stores.Where(s => s.StoreId == id).First();
            BL.Store searched = new BL.Store(store.StoreId, store.StoreName);
            return searched;
        }
    }
}