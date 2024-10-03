using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyOTTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController1 : ControllerBase
    {
        // GET: api/<UsersController1>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var ss = "rachuri";
            return "value";
        }

        // POST api/<UsersController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
