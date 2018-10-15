using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sakila.DB;
using Microsoft.EntityFrameworkCore;
using Sakila.Service;
using Sakila.Security;
using Microsoft.AspNetCore.Identity;
using Sakila.Middleware;

namespace Sakila
{
    public class Startup
    {
        private readonly int SakilaDbContext;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddDistributedMemoryCache();
            services.AddSession();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<SakilaDbContext>(options => 
                options.UseMySql(Configuration.GetConnectionString("sakila")));

            services.AddScoped(typeof(FilmService));
            services.AddScoped(typeof(LanguageService));
            services.AddScoped(typeof(CustomerService));

            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();

            configureIdentity(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            

            app.UseSession();

            app.UseIdentity();

             app.UseLogMiddleware(new LogMiddlewareOptions(){FilePath = "c:\\windows\\temp\\sakila.log"});

             

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "area",
                    template: "{area:exists}/{controller}/{action}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

           
        }
    
        private void configureIdentity(IServiceCollection services) {
            services.AddIdentity<ApplicationUser,ApplicationRole>()
            .AddEntityFrameworkStores<SakilaDbContext>()
            .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options => {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.User.RequireUniqueEmail = true;
                
            });
        }
    }
}
