using Microsoft.AspNetCore.Mvc;

namespace tasksAPI.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [HttpGet]
        public string[] GetAllTasks()
        {
            return new string[] { "Tarea1", "Tarea2", "Tarea3" };
        }
    }
}