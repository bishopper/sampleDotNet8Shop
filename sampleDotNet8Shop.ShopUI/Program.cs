using Microsoft.EntityFrameworkCore;
using sampleDotNet8Shop.ShopUI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var cnnString = builder.Configuration.GetConnectionString("ShopCnn");
builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(cnnString));

builder.Services.AddScoped<IProductRepository, EFProductRepository>();


var app = builder.Build();


// middleware
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}:/page{pageNumber}");
            endpoints.MapDefaultControllerRoute();
        }
);

app.Run();
