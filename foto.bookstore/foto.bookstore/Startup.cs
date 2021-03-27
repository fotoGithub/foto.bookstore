using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foto.bookstore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.Use(async(context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from my first middleware");
            //    await next();
            //    await context.Response.WriteAsync("hello from my first middleware response");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from my second middleware");
            //    await next();
            //    await context.Response.WriteAsync("hello from my second middleware response");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from my third middleware");
            //    await next();
               
            //});
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapGet("/", async context =>
                //{
                //    if (env.IsDevelopment())
                //    {
                //        await context.Response.WriteAsync("Hello from dev");
                //    }
                //    else if (env.IsProduction())
                //    {
                //        await context.Response.WriteAsync("Hello from Prod");
                //    }
                //    else if (env.IsStaging())
                //    {
                //        await context.Response.WriteAsync("Hello from staging");
                //    }
                //    else
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/ajay", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello ajay from!");
            //    });
            //});
        }
    }
}
