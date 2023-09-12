using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// convention bases routing
// route 1 .. more specific
app.MapControllerRoute(
    name:"first", // any custom value
    pattern:"{action}/{id?}",
    defaults: new {Controller = "Home", Action = "Index"}
    );

// route 2 .. generalized 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
