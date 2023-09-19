using System.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
//using mysql_connect.Data;

namespace Resume.Presentation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        //builder.Services.AddDbContextPool<ApplicationDBContext>(options =>
        //options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
        //);


        //builder.services.AddDatabaseDeveloperPageExceptionFilter();
        //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.Signin.RequireConfirmedAccount = true)
        //.AddEntityFrameworkStores < ApplicationDbContext > ();

//        Services.Add(new ServiceDescriptor(typeof(SakilaContext), new SakilaContext(Configuration.GetConnectionString
//(        "DefaultConnection"))));
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

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}

