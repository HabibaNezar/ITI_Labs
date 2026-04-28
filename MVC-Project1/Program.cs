using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_Project1.Context;
using MVC_Project1.Middlewares;
using MVC_Project1.Models;
using MVC_Project1.Repository;
using Microsoft.AspNetCore.StaticFiles; // Add this to the top of Program.cs

namespace MVC_Project1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();

            /*----------------------------------------------------------------------------*/
            /*------------------------Session---------------------------------------------*/

            builder.Services.AddDistributedMemoryCache(); // ??? ????

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            /*----------------------------------------------------------------------------*/
            // custom service nd need to register it in the program.cs file
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            /*----------------------------------------------------------------------------*/

            /*----------------------------user identity------------------------------------------------*/
            builder.Services.AddDbContext<DbAppContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 4;
            })
                .AddEntityFrameworkStores<DbAppContext>()
                .AddDefaultTokenProviders();
            /*----------------------------------------------------------------------------*/



            var app = builder.Build();

            // 1. Create a provider to map new file types
            var provider = new FileExtensionContentTypeProvider();

            // 2. Add the MIME type for .glb files
            provider.Mappings[".glb"] = "model/gltf-binary";
            provider.Mappings[".gltf"] = "model/gltf+json"; // Good to add just in case!

            // 3. Tell the app to use static files WITH your new provider
            app.UseStaticFiles(new StaticFileOptions
            {
                ContentTypeProvider = provider
            });



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            //app.UseMiddleware<LoggingMiddleware>();
            app.UseLoggingMiddleware();

            /*----------------------------------------------------------------------------*/

            app.UseRouting();


            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
