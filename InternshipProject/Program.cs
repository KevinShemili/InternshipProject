using Application;
using Infrastructure;
using InternshipProject.Middleware;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args); 

// Services Scope
{
    builder.Services.AddProblemDetails();

    builder.Services
        .AddApplicationLayer()
        .AddInfrastructureLayer(builder.Configuration);

    builder.Services.AddAutoMapper(typeof(Program).Assembly);

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c => {
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme() {
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header
        });
        c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
    });
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

    app.UseAuthentication();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
