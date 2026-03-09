using Microsoft.Extensions.Configuration;
using Npgsql;
using Dapper;
using Tasks.Application.DTOs;
using Tasks.Application.Interfaces;

namespace Tasks.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly string _connectionString;

        public TaskRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<TaskResponse>> GetTasksAsync(string? status, string? priority)
        {
            using var connection = new NpgsqlConnection(_connectionString);

            var sql = "SELECT * FROM sp_get_tasks(@p_status, @p_priority)";

            return await connection.QueryAsync<TaskResponse>(
                sql,
                new
                {
                    p_status = status,
                    p_priority = priority
                });
        }

        public async Task<TaskResponse?> GetTaskByIdAsync(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);

            var sql = "SELECT * FROM sp_get_task_by_id(@p_id)";

            return await connection.QueryFirstOrDefaultAsync<TaskResponse>(
                sql,
                new { p_id = id });
        }
    }
}
