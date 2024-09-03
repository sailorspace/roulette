using Dapr.Client;
using System.Text.Json;
using WeatherMvcFront.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddDapr();
builder.Services.AddSingleton<IWeatherClient, WeatherClient>(_=>new WeatherClient(DaprClient.CreateInvokeHttpClient("weatherapi")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
