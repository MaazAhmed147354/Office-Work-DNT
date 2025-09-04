using backend_dotnet.Data;
using backend_dotnet.Helpers;
using backend_dotnet.Repositories;
using backend_dotnet.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
                      {
                          //policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
                          policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                      });
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddScoped<IOrderDataRepository, OrderDataRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IProductWarrantyRepository, ProductWarrantyRepository>();
builder.Services.AddScoped<IProductWarrantyService, ProductWarrantyService>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<ISalesRepository, SalesRepository>();
builder.Services.AddScoped<ISalesService, SalesService>();

// Register JwtTokenHelper
builder.Services.AddScoped<JwtTokenHelper>();

// Register Auth Service
builder.Services.AddScoped<IAuthService, AuthService>();

// Add JWT Authentication
builder.Services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
        };
    });
builder.Services.AddAuthorization();
Console.WriteLine(DateTime.UtcNow.AddDays(-1));
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthentication(); // <-- Must be before UseAuthorization
app.UseAuthorization();

app.MapControllers();

app.Run();
