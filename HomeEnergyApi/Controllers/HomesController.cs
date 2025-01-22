using Microsoft.AspNetCore.Mvc;
using HomeEnergyApi.Models;

namespace HomeEnergyUsageApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomesController : ControllerBase
    {
        private static HomeRepository repository = new HomeRepository();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repository.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)

        {
            Home foundHome = repository.FindById(id);
            if (foundHome != null)
            {
                return Ok(repository.FindById(id));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreateHome([FromBody] Home home)
        {
            repository.Save(home);
            return Created($"/Homes/{repository.FindAll().Count - 1}", home);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHome([FromBody] Home newHome, [FromRoute] int id)
        {
            Home homeToUpdate = repository.FindById(id);
            if (homeToUpdate != null)
            {
                repository.Update(id, newHome);
                return Ok(repository.FindById(id));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHome(int id)
        {
            Home homeToDelete = repository.FindById(id);

            if (homeToDelete != null)
            {
                repository.RemoveById(id);
                return Ok(homeToDelete);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
