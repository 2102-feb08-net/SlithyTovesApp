using Microsoft.AspNetCore.Mvc;
using Project1.BL;


namespace Project1.WebUI.Controllers
{
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly Project1.BL.IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        [HttpGet("storebyid/{id}")]
        public BL.Store GetStoreById(int id)
        {
            return _storeRepository.GetStoreById(id);
        }
    }
}