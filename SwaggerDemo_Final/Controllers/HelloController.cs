using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        // GET /api/hello
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from Swagger-enabled Web API!");
        }

        // POST /api/hello
        [HttpPost]
        public IActionResult Post([FromBody] string message)
        {
            return Ok($"Received: {message}");
        }

        // PUT /api/hello
        [HttpPut]
        public IActionResult Put([FromBody] string message)
        {
            return Ok($"Updated: {message}");
        }

        // DELETE /api/hello/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleted message with ID: {id}");
        }
    }
}
