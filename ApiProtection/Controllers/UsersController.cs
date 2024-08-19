using ApiProtection.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiProtection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        //[ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = false)]
        public IEnumerable<string> Get()
        {
            return new string[] { Random.Shared.Next(1, 101).ToString() };
        }

        [HttpGet("{id}")]
        //[ResponseCache(Duration = 20, Location = ResponseCacheLocation.Any, NoStore = false)]
        public string Get(int id)
        {
            return $"Random Number: { Random.Shared.Next(1, 101) } for Id {id}";
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserModel user)
        {
            if (ModelState.IsValid)
            {
                return Ok("The model was valid");
            }
            else 
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
