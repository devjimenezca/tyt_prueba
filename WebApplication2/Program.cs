using Microsoft.EntityFrameworkCore;
using WebApplication2.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<DataDbContext>(options => options
 .UseSqlServer(@"Data Source=DESKTOP-L94Q7CS\MSSQLSERVER2019;Initial Catalog=TYT_PRUEBA;Persist Security Info=False;User ID=sa; Password=12345;")
);

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
