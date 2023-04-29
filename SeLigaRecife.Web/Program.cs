using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SeLigaRecife.Web.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<SeLigaRecifeDbContext>(options =>
    options.UseMySql("Server=seligabencadb.mysql.database.azure.com;UserID = seligabencaadmin;Password=thaispaes@123;Database=seliga_recife_db;",
        ServerVersion.Parse("8.0.32-mysql", ServerType.MySql),
        m => m.MigrationsAssembly(typeof(SeLigaRecifeDbContext).Assembly.FullName)));

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
    pattern: "{controller=Point}/{action=Index}/{id?}");

app.Run();
