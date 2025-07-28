using Todo.Interface;
using Todo.Repositories;
using Todo.Services;
using Microsoft.EntityFrameworkCore;
using Todo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
//builder.Services.AddSingleton<ITodoRepository, InMemoryTodoRepository>();
builder.Services.AddScoped<ITodoRepository, DbTodoRepository>();
builder.Services.AddScoped<TodoService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
