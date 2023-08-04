using Microsoft.EntityFrameworkCore;
using OceanicaAPI.Data;
using OceanicaAPI.Models;
using OceanicaAPI.Repository;
using OceanicaAPI.Repository.Abstract;

var builder = WebApplication.CreateBuilder(args);

//ConnectionString
var connectionString = builder.Configuration.GetConnectionString("OceanicaConnection");

// Add services to the container.
builder.Services.AddScoped<IRepository<Vessel>, VesselRepository>();

//AddAutomapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Add Context
builder.Services.AddDbContext<OceanicaContext>(opt =>
opt.UseLazyLoadingProxies().UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Enable CORS
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", opt => opt.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

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
