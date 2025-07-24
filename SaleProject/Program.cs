using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;

var builder = WebApplication.CreateBuilder(args);




//-----------------------------------------me---------------------------------------------//
// --- Add this section ---
// 1. Get the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. Add the DbContext to the services container
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString) // 3. Specify that we are using PostgreSQL
);  


//-----------------------------------------me---------------------------------------------//




// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
