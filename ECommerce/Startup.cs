using BusinessLogic.Services;
using ECommerce.Models;
using InfraStructure.Database;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
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
            services.AddControllersWithViews();

            services.AddDbContext<MyDbContext>(
            option => option.UseSqlServer(Configuration.GetConnectionString("con"),b => b.MigrationsAssembly("ECommerce"))
            .LogTo(s => Console.WriteLine(s)));

            services.AddScoped<GenericRepository<User>>();
            services.AddScoped<GenericRepository<InfraStructure.Entity.Type>>();
            services.AddScoped<GenericRepository<Category>>();
            services.AddScoped<GenericRepository<Brand>>();
            services.AddScoped<GenericRepository<Product>>();
            services.AddScoped<GenericRepository<Color>>();
            services.AddScoped<GenericRepository<Size>>();
            services.AddScoped<GenericRepository<Image>>();
            services.AddScoped<AccountRepository>();

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MyDbContext>();

            services.AddAutoMapper(x=> x.AddProfile(new ECommerce.Models.MyProfile()));
            services.AddAutoMapper(x => x.AddProfile(new BusinessLogic.Models.MyProfile()));

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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");
            });
        }
    }
}
