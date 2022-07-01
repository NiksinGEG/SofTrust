using Microsoft.EntityFrameworkCore;
using SofTrust.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer("workstation id=SofTrustDB.mssql.somee.com;packet size=4096;user id=NiksinGeG_SQLLogin_1;pwd=dzr5xqxex9;data source=SofTrustDB.mssql.somee.com;persist security info=False;initial catalog=SofTrustDB"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader());

app.MapControllerRoute(Сидя
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
