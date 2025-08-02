using backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OutletController : ControllerBase
    {
        private readonly OutletRepository _repository;

        public OutletController(OutletRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            await _repository.Add(new Models.Outlet());
            return Ok(await _repository.GetAll());
        }
    }
}
