using CleanArch.Application;
using CleanArch.Infrastructure;
using CleanArch.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DbContextFist>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
   ));


builder.Services.AddControllers();
builder.Services.AddScoped<IMasterFieldRepository, MasterFieldRepository>();
builder.Services.AddScoped<IMasterFieldService, MasterFieldService>();
    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
