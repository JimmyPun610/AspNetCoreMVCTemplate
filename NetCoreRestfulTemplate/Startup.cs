using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NetCoreRestfulTemplate
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

            #region CORS
            services.AddCors(options =>
            {
                options.AddPolicy("CORSPolicy", builder =>
                {
                    //To allow all
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    //To allow some
                    //builder.WithHeaders("Header_A", "Header_B");
                    //builder.WithMethods("GET", "POST", "PUT", "DELETE");
                    //builder.WithOrigins("http://example.com");
                });
            });
            #endregion

            #region Swagger
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Version = "v1",
                    Title = "Restful Template",
                    Description = "This is a template for swagger in .NET Core",
                    TermsOfService = new Uri("https://github.com"),
                    Contact = new OpenApiContact
                    {
                        Name = "Jimmy Pun",
                        Email = "11005408@life.hkbu.edu.hk",
                        Url = new Uri("https://www.linkedin.com/in/punchunghang/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "License Part",
                        Url = new Uri("https://example.com/license-web-page/")
                    }
                });
            });
            #endregion
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
            #region Swagger
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Restful Template");
            });
            #endregion

            app.UseRouting();
            #region CORS
            app.UseCors("CORSPolicy");
            #endregion
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
