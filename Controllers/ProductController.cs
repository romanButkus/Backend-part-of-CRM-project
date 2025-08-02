using backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductController(ProductRepository repository)
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
            await _repository.Add(new Models.Product());
            return Ok(await _repository.GetAll());
        }
    }
}
