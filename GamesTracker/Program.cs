using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GamesTracker.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GamesTrackerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GamesTrackerContext") ?? throw new InvalidOperationException("Connection string 'GamesTrackerContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Games}/{action=Index}/{id?}");

app.Run();
