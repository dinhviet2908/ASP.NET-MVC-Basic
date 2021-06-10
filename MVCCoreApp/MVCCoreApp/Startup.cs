using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using MVCCoreApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp
{
    public class Startup
    {
        IHostingEnvironment _env;
        public Startup(IHostingEnvironment env)
        {
            _env = env;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            if(_env.IsProduction())
                services.AddTransient<IProductService, ProductService>();
            //else services.AddTransient<IProductService, ProductionProductService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvcWithDefaultRoute();
            //app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id:int?}");
                //routes.MapRoute("default", "{controller=Home}/{action=Index}/{id}",
                //    new { controller = "Home", action = "Index" },
                //    new { id = new IntRouteConstraint()});
                //routes.MapRoute("default", "post/{id:int}",
                //    new { controller = "Post", action = "PostByID" });
                //routes.MapRoute("anotherRoute", "post/{id:alpha}",
                //    new { controller = "Post", action = "PostByPostName" });

                //int, alpha, bool, datetime, decimal, double, float, guid
                //{id:length(12)}, minlength, maxlength, range ...
                //regrex
                //{id:alpha:minlength(6)}
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });

        }
    }
}
