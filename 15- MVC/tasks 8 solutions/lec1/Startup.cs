using lec1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lec1
{



    public class Startup
    {
        //request service of type Iconfiguration to be used here , create & inject this service 
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); //enable MVC service "Contained"
            services.AddDbContext<SCCaiContext>
                (
                   //op=>op.UseSqlServer("Data Source=.;Initial Catalog=SCCaiDB;Integrated Security=True") 
                  op => op.UseSqlServer(Configuration["ConnectionStrings:myConn"])
                  // op=>op.UseSqlServer(Configuration.GetConnectionString("myConn")
                ) ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); // go to wwwroot first

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute
                (
                    name: "myOwnRoute",
                    pattern: "{Controller=Product}/{Action=Index}/{id?}"
                );
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World! " + Configuration["myKey"]);
                //});
            });
        }
    }
}
