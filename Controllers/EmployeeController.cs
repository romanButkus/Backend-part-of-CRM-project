using backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _repository;

        public EmployeeController(EmployeeRepository repository)
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
            await _repository.Add(new Models.Employee());
            return Ok(await _repository.GetAll());
        }
    }
}
