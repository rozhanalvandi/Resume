using System.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Resume.Presentation.Models.ResumeDbContext;


namespace Resume.Presentation;

public class Program
{

    //public IConfiguration Configuration { get; }
    //public Program(IConfiguration configuration)
    //{
    //    Configuration = configuration;

    //}
    //public void ConfigureServices(IServiceCollection services)
    //{
    //    services.AddDbContextPool<ResumeDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));
    //}

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<ResumeDbContext>(x =>
        x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

