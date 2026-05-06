using COMP003B.SP26.FinalProject.IannazzoS.Data;
using Microsoft.EntityFrameworkCore;
// Author: Samuel Iannazzo
// Course: COMP-003B: ASP.NET Core
// Instructor: Johnathan Cruz
// Purpose: Final project synthesizing MVC, Web API, EF Core, and Middleware
namespace COMP003B.SP26.FinalProject.IannazzoS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // database context setup
            builder.Services.AddDbContext<PatientLogContext>(options =>
              options.UseSqlServer("Name=ConnectionStrings:DefaultConnection"));

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.UseMiddleware<COMP003B.SP26.FinalProject.IannazzoS.Middleware.RequestLoggingMiddleware>();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
