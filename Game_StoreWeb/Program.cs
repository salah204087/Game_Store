using Game_StoreWeb;
using Game_StoreWeb.Services;
using Game_StoreWeb.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

builder.Services.AddAutoMapper(typeof(Mapping));
builder.Services.AddHttpClient<IGameTypeService, GameTypeService>();
builder.Services.AddScoped<IGameTypeService, GameTypeService>();
builder.Services.AddHttpClient<IGameCompanyService, GameCompanyService>();
builder.Services.AddScoped<IGameCompanyService, GameCompanyService>();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
