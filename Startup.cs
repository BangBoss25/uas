using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Data;
using uas.Models;
using uas.Repositories.AkunRepository;
using uas.Repositories.Repository;
using uas.Services;
using uas.Services.AkunService;
using uas.Services.Service;

namespace uas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(o =>
            {
                o.UseMySQL(Configuration.GetConnectionString("mysql")); //sesuaikan namanya
            });

            services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", options =>
                {
                    options.LoginPath = "/Akun/SignIn";
                    options.AccessDeniedPath = "/Home/Dilarang";
                });

            services.AddScoped<IAkunRepository, AkunRepository>();
            services.AddScoped<IAkunService, AkunService>();

            services.AddScoped<IStuffRepository, StuffRepository>();
            services.AddScoped<IStuffService, StuffService>();

            services.AddTransient<FileService>();
            services.AddTransient<EmailService>();

            services.Configure<Email>(Configuration.GetSection("AturEmail"));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "AreaAdmin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapAreaControllerRoute(
                    name: "AreaUser",
                    areaName: "User",
                    pattern: "User/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Akun}/{action=SignIn}/{id?}");
            });
        }
    }
}
