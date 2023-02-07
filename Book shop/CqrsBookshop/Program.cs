using CqrsBookshop;
using CqrsBookshop.Behaviours;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMediatR(typeof(Program));
builder.Services.AddSingleton<DataStore>();
builder.Services.AddSingleton(typeof(IPipelineBehavior<,>),typeof(LoggingBehaviour<,>));
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
