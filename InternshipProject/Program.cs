using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args); 

// Services Scope
{
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

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
