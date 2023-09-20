using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;


namespace tasksAPI.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IConnectionMultiplexer _redis;

        public MainController(IConnectionMultiplexer redis)
        {
            _redis = redis;
        }
        
        [HttpGet]
        public ActionResult<string> GetAllTasks()
        {
            IDatabase db = _redis.GetDatabase();
            string value = db.StringGet("Hola");
            return Ok(value);
        }
    }
}