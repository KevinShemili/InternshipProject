using Application;
using Infrastructure;
using InternshipProject.Middleware;

var builder = WebApplication.CreateBuilder(args); 

// Services Scope
{
    builder.Services.AddProblemDetails();

    builder.Services
        .AddApplicationLayer()
        .AddInfrastructureLayer(builder.Configuration);

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build(); 


// Middleware Scope
{
    if (app.Environment.IsDevelopment()) {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseMiddleware<ExceptionHandlingMiddleware>();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
