using Game_StoreAPI.Repository.IRepository;
using Game_StoreAPI.Repository;
using Game_StoreWeb;
using Game_StoreWeb.Models;
using Game_StoreWeb.Services;
using Game_StoreWeb.Services.IServices;
using Microsoft.AspNetCore.Authentication.Cookies;
using Game_StoreAPI.Data;
using Microsoft.EntityFrameworkCore;
using Game_StoreAPI.Models;
using Microsoft.AspNetCore.Identity;
using Game_StoreAPI.Services.IServices;
using Game_StoreAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(Mapping));
builder.Services.AddHttpClient<IGameTypeService, GameTypeService>();
builder.Services.AddScoped<IGameTypeService, GameTypeService>();
builder.Services.AddHttpClient<IGameCompanyService, GameCompanyService>();
builder.Services.AddScoped<IGameCompanyService, GameCompanyService>();
builder.Services.AddHttpClient<IPlatformService, PlatformService>();
builder.Services.AddScoped<IPlatformService, PlatformService>();
builder.Services.AddHttpClient<IGameService, GameService>();
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddHttpClient<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


builder.Services.AddDistributedMemoryCache();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
              .AddCookie(options =>
              {
                  options.Cookie.HttpOnly = true;
                  options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                  options.LoginPath = "/Auth/Login";
                  options.AccessDeniedPath = "/Auth/AccessDenied";
                  options.SlidingExpiration = true;
              });
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(100);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
// Add services to the container.



builder.Services.AddControllersWithViews();


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

app.UseAuthentication();
app.UseAuthorization();
app.UseSession();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
