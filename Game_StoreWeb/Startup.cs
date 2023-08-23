using Game_StoreAPI.Data;
using Game_StoreAPI.Repository.IRepository;
using Game_StoreAPI.Repository;
using Game_StoreAPI.Services.IServices;
using Game_StoreAPI.Services;
using Game_StoreWeb.Models;
using Game_StoreWeb.Services;
using Game_StoreWeb.Services.IServices;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Game_StoreWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddAutoMapper(typeof(Mapping));
            services.AddHttpClient<IGameTypeService, GameTypeService>();
            services.AddScoped<IGameTypeService, GameTypeService>();
            services.AddHttpClient<IGameCompanyService, GameCompanyService>();
            services.AddScoped<IGameCompanyService, GameCompanyService>();
            services.AddHttpClient<IPlatformService, PlatformService>();
            services.AddScoped<IPlatformService, PlatformService>();
            services.AddHttpClient<IGameService, GameService>();
            services.AddScoped<IGameService, GameService>();
            services.AddHttpClient<IAuthService, AuthService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDistributedMemoryCache();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                    options.LoginPath = "/Auth/Login";
                    options.AccessDeniedPath = "/Auth/AccessDenied";
                    options.SlidingExpiration = true;
                });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(100);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // Add session middleware
            app.UseSession();

            // Add session event handler
            app.Use(async (context, next) =>
            {
                var session = context.Session;
                var shoppingCart = context.RequestServices.GetService<ShoppingCart>(); // Replace with the actual service type of your shopping cart.

                if (session.IsAvailable && !session.Keys.Contains("CartId"))
                {
                    var items = shoppingCart.GetShoppingCartItems();

                    foreach (var item in items)
                    {
                        var game = context.RequestServices.GetService<ApplicationDbContext>().Games.FirstOrDefault(n => n.Id == item.Game.Id);
                        if (game != null)
                        {
                            game.Quantity += item.Amount;
                        }
                    }

                    context.RequestServices.GetService<ApplicationDbContext>().SaveChanges();
                }

                await next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
