using Microsoft.EntityFrameworkCore;
using Supplier1.Data;
var builder = WebApplication.CreateBuilder(args);
var conn = "Data Source=PANDULA_ASUS;Initial Catalog=Supplier1;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(conn));
// Add services to the container.
builder.Services.AddScoped<ProductRepo>();
builder.Services.AddScoped<OrderRepo>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
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
