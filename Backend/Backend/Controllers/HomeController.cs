using System.Threading.Tasks;
using Backend.DAL.Collections;
using Backend.Models;
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
            return Ok(await _formService.GetAsync());
        }

        // GET api/values/5
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Registration>> GetById(string id)
        {
            var form = await _formService.GetByIdAsync(id);
            if (form == null)
            {
                return NotFound();
            }

            return Ok(await _formService.GetByIdAsync(id));
        }

        // PUT api/values/5
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Put(string id, [FromBody] FormModel model)
        {
            Registration item = await _formService.GetByIdAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _formService.Update(id, item, model);

            return NoContent();
        }
    }
}
