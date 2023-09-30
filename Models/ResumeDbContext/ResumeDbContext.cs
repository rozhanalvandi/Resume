using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
namespace Resume.Presentation.Models.ResumeDbContext
{
    public class ResumeDbContext : DbContext
    {

        static readonly string connectionString = "Server=localhost; User ID=root; Password=1234; Database=ResumeDaneshkar";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
    

}

