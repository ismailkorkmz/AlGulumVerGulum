using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AldimGulumVerdimGulum.CustomValidation;
using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concreate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Contex.EntityFramework;
using DataAccessLayer.SeedData;
using Entity.POCO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AldimGulumVerdimGulum
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategory>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProduct>();
            services.AddDbContext<AlGulumVerGulumDbContex>();
            services.AddIdentity<AppUser, AppRole>(x =>
            {
                x.Password.RequiredLength = 3;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireDigit = false;
                x.User.RequireUniqueEmail = true;

            })
                .AddErrorDescriber<ErrorDisciberAccount>()
                .AddEntityFrameworkStores<AlGulumVerGulumDbContex>();

            //services.AddTransient --Baðýmlýlýk nesne oluþturulduðunda her çaðýrýlmasýnda nesne üretir
            //services.AddSingleton --Tek bir nesne üretir ve bütün istekleri o nesneden karþýlar

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Seed.Seed1();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
        }
    }
}