using Microsoft.AspNetCore.Mvc;
using Project1.BL;


namespace Project1.WebUI.Controllers
{
    [ApiController]
    [Route("api/store")]
    public class StoreController : ControllerBase
    {
        private readonly Project1.BL.IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        [HttpGet("storebyid/{id}")]
        public ActionResult<BL.Store> GetStoreById(int id)
        {
            var store =  _storeRepository.GetStoreById(id);
            return Ok(store);
        }
    }
}