
using System.Reflection;
using bmsgateway;
using bmsgateway.DB;
using bmsgateway.repository;
using bmsgateway.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddScoped<IDbService,DbService>();
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddSingleton<IBmsPolicymaker,BmsPolicyMaker>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
