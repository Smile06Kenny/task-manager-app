using dotenv.net;
using NLog;
using NLog.Web;
using System.Text.Json;
using Tasks.Application.Interfaces;
using Tasks.Application.Response;
using Tasks.Infrastructure.Repositories;

if (File.Exists(".env"))
{
    DotEnv.Fluent().WithExceptions().WithoutOverwriteExistingVars().Load();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
GlobalDiagnosticsContext.Set("ConnectionString", builder.Configuration.GetConnectionString("ConnectionString"));
GlobalDiagnosticsContext.Set("AppName", builder.Configuration["App:Name"]);
GlobalDiagnosticsContext.Set("Script", builder.Configuration["Nlog:Script"]);
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Logging.ClearProviders();
builder.Host.UseNLog();

var logger = LogManager.GetCurrentClassLogger();

try
{
    logger.Info("NLog configurado correctamente");

    builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        });
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            var response = new ResponseApp<object>(
                StatusCodes.Status500InternalServerError,
                "Error inesperado, intentelo más tarde.",
                null
            );

            await context.Response.WriteAsJsonAsync(response);
        });
    });

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseCors("CorsPolicy");

    app.UseAuthentication();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();


}
catch (Exception ex)
{
    logger.Error(ex, "Stopped program because of exception");
    Environment.ExitCode = 1;
}
finally
{
    LogManager.Shutdown();
}

