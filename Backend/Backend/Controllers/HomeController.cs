using System.Threading.Tasks;
using Backend.DAL.Collections;
using Backend.DAL.Repositories;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly FormService _formService;

        public HomeController(FormService formService)
        {
            _formService = formService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var aa = await _formService.GetAsync();
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            return Ok();
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Create()//[FromBody] EmployeeCreationDto employee)
        {
            return NoContent();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id)//, [FromBody] EmployeeEditDto employee)
        {

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            return NoContent();
        }
    }
}
