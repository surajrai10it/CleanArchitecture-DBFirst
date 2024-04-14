using CleanArch.Api;
using CleanArch.Application;
using CleanArch.Infrastructure;
using CleanArch.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


Console.WriteLine(builder.Configuration["MyKey"]);



// Add services to the container.
builder.Services.AddDbContext<DbContextFist>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
   ));


builder.Services.AddControllers();
builder.Services.Configure<MyOptions>(builder.Configuration.GetSection("Logging:LogLevel"));

builder.Services.AddScoped<IMasterFieldRepository, MasterFieldRepository>();
builder.Services.AddScoped<IMasterFieldService, MasterFieldService>();
    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.Use(async (context, next) =>
{
    Console.WriteLine("value is" + builder.Configuration["MyKey"]);
    // system variable path of your system......
    Console.WriteLine("value of path " + builder.Configuration["Path"]);
    Console.WriteLine("value is" + builder.Configuration["MyKey"]);
    Console.WriteLine("value is" + builder.Configuration["Logging:LogLevel:Default"]);

    var myOptions = new MyOptions();
    builder.Configuration.GetSection("Logging:LogLevel").Bind(myOptions);
    Console.WriteLine("value is..." + myOptions.Default);

    await next();
});


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
