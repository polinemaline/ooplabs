using Microsoft.EntityFrameworkCore;
using oop3.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*string connection = builder.Configuration.GetConnectionString("DefaultConnection");*/
string connection = builder.Configuration["ConnectionStrings:DefaultConnection"];
/*builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connection));*/
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connection));
//builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext")));


//builder.Services.AddDatabaseDeveloperPageExceptionFilter();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();