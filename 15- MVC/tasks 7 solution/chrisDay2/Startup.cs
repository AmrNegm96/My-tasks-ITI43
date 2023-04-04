using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chrisDay2
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline(set of middleware components).
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region inline middleware
            //inline middleware ==> anonymous function
            //app.Use(async (context, next) =>
            //{
            //    //car add to response or not 
            //    await context.Response.WriteAsync("1) Middleware 1 \n");
            //    //can call nex middleware or not "short circuit"
            //    await next.Invoke();
            //    await context.Response.WriteAsync("1.1) Middleware 1.1 \n");

            //});

            //app.Use(async (context, next) =>
            //{
            //    //car add to response or not 
            //    await context.Response.WriteAsync("2) Middleware 2 \n");  // according to business 
            //    //can call nex middleware or not "short circuit"
            //    await next.Invoke();

            //    await context.Response.WriteAsync("2.2) Middleware 2.2 \n");  // according to business 

            //});

            //app.Run(async (context) =>
            //{
            //    //car add to response or not 
            //    await context.Response.WriteAsync("3) Terminate 3 \n");  // according to business 

            //});

            //app.Use(async (context, next) =>
            //{
            //    //car add to response or not 
            //    await context.Response.WriteAsync("4) Middleware 4 \n");  // according to business 
            //    //can call nex middleware or not "short circuit"
            //    await next.Invoke();
            //});

            #endregion

            #region middleware component
            //middleware component
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            #endregion

        }
    }
}
