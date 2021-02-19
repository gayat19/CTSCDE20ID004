using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWebProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISampleInterface, SampleService>();
            Action<MvcOptions> action = new Action<MvcOptions>(m =>
            {
                m.EnableEndpointRouting = false;
            });
            services.AddMvc(action);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ISampleInterface sample)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.Use(async (ctx,next) =>
            {
                sample.PrintTest();
                await ctx.Response.WriteAsync("From the first run");
                await next();
            });
            app.Run(async (ctx) =>
            {
                sample.PrintTest();
                await ctx.Response.WriteAsync("Look we have written to the response");
            });
            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync(env.EnvironmentName);
            //    });
            //});
        }
    }
    public interface ISampleInterface
    {
        void PrintTest();
    }
    class SampleService : ISampleInterface
    {
        public void PrintTest()
        {
            Console.WriteLine("Hello from test Service");
        }
    }
}
