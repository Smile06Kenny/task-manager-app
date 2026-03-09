using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Application.DTOs;

namespace Tasks.Application.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskResponse>> GetTasksAsync(string? status, string? priority);

        Task<TaskResponse?> GetTaskByIdAsync(int id);
    }
}
