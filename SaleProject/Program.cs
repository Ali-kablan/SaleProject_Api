using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Repository;
using SaleProject.Services.Customer;
using SaleProject.Services.Product;
using SaleProject.Services.Supplier;

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

// 3. --- REGISTER YOUR REPOSITORIES AND SERVICES HERE ---
// AddScoped means a new instance is created for each web request.

// Register the Generic Repository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


// Register specific repositories

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();



// Register your specific services (repeat for each service)
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();
// builder.Services.AddScoped<ICustomerService, CustomerService>(); // Add these as you create them
// builder.Services.AddScoped<ISaleInvoiceService, SaleInvoiceService>(); // Add these as you create them
// ... and so on for all your services



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
