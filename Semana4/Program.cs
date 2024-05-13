using Microsoft.EntityFrameworkCore;
using Semana4.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
// Rutas Personalizadas que conecta con el Controlador Default ( En este caso seria: HomeController )
endpoints.MapControllerRoute(
    name: "Home",
    pattern: "Home",
    defaults: new { controller = "Home", action = "Index" });

endpoints.MapControllerRoute(
    name: "Privacy",
    pattern: "Privacy",
    defaults: new { controller = "Home", action = "Privacy" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Model}/{action=Index}/{id?}");
    });

app.Run();
