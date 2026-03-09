
using Microsoft.AspNetCore.Mvc;
using Tasks.Application.DTOs;
using Tasks.Application.Interfaces;
using Tasks.Application.Response;

namespace Tasks.API.Controllers
{
    [Route("api/Tasks/")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        #region Variables
        private readonly ITaskRepository _repository;

        #endregion

        #region Constructor
        public TasksController(ITaskRepository repository)
        {
            _repository = repository;

        }
        #endregion

        #region Methods

        [HttpGet]
        [ProducesResponseType(typeof(ResponseApp<IEnumerable<TaskResponse>>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTasks(
            [FromQuery] string? status,
            [FromQuery] string? priority)
        {
            var tasks = await _repository.GetTasksAsync(status, priority);

            var response = new ResponseApp<IEnumerable<TaskResponse>>(tasks);

            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            var task = await _repository.GetTaskByIdAsync(id);

            if (task == null)
            {
                return NotFound(new ResponseApp<TaskResponse>(
                     StatusCodes.Status404NotFound,
                    "Tarea no encontrada",
                    null
                ));
            }

            return Ok(new ResponseApp<TaskResponse>(task));
        }

        #endregion
    }
}
