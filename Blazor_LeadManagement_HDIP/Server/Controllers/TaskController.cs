using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_LeadManagement_HDIP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseMessage<List<LeadTask>>>> GetTasks()
            {
            var tasks = await _taskService.GetTasksAsync();
            return Ok(tasks);
            }

        [HttpGet("task/{leadid}")]
        public async Task<ActionResult<ResponseMessage<List<LeadTask>>>> GetProductsByCategory(int leadid)
        {
            var result = await _taskService.GetTaskByLeadID(leadid);
            return Ok(result);
        }

    }
}
