using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Resume.Presentation.Models.Entitis.Education;
using Resume.Presentation.Models.Entitis.Exprience;
using Resume.Presentation.Models.Entitis.MySkills;


namespace Resume.Presentation.Models.ResumeDbContext
{
    public class ResumeDbContext : DbContext
    {
        //Dbcontext implementation
        public ResumeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Exprience> Expriences { get; set; }
        public DbSet<MySkills> MySkills { get; set; }


    }

    public class YourDbContextFactory : IDesignTimeDbContextFactory<ResumeDbContext>
    {
        public ResumeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ResumeDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=ResumeDaneshkar;User Id=sa; Password=Strong.Pwd-123");

            return new ResumeDbContext(optionsBuilder.Options);
        }
    }


}

