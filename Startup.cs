using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyServices.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CompanyServices.Domain;
using CompanyServices.Domain.Repositories.Abstract;
using CompanyServices.Domain.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CompanyServices
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            //conectam config din appsettings.json
            Configuration.Bind("Project", new Config());

            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();

            //adaugam contextul din baza de date 
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //setam identity system
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //setam authentification cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            //setam politica de autorizare pentru Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            //adaugam servicii pentru controller si view (MVC)
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })

                //setam compatibilitatea cu asp.net core 3.0 
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())//afiseaza probleme site-ului cand suntem in regim development
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//sistemul de rutare
            //sustinerea fisierelor statice in aplicatie(js, css, etc)
            app.UseStaticFiles();

            //adaugam registrarea si autorizarea
            app.UseCookiePolicy(); 
            app.UseAuthentication();
            app.UseAuthorization();

            //inregistram endpoint-urile noastre
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
