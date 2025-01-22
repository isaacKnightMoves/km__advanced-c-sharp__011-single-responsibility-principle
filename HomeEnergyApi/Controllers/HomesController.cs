using Microsoft.AspNetCore.Mvc;
using HomeEnergyApi.Models;

namespace HomeEnergyUsageApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomesController : ControllerBase
    {
        private static List<Home> homesList = new List<Home>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(homesList);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)

        {
            Home foundHome = homesList[id];
            if (foundHome != null)
            {
                return Ok(homesList[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreateHome([FromBody] Home home)
        {
            homesList.Add(home);
            return Created($"/Homes/{homesList.Count - 1}", home);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHome([FromBody] Home newHome, [FromRoute] int id)
        {
            Home homeToUpdate = homesList[id];
            if (homeToUpdate != null)
            {
                homesList[id] = newHome;
                return Ok(homesList[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHome(int id)
        {
            Home homeToDelete = homesList[id];

            if (homeToDelete != null)
            {
                homesList.Remove(homeToDelete);
                return Ok(homeToDelete);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
