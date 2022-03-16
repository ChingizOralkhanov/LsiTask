using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace LsiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        // GET: api/<ExportController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ExportController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExportController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExportController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExportController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
