using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // This line is necessary to enable MVC
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage(); // Leaves a detailed explanation of errors
            }

            app.UseStaticFiles();

            app.UseRouting();

            // Endpoints define what the user needs to type in order to go somewhere and where they will go if they type that
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default", // If the user doesn't type anything...
                    pattern: "{controller=Blah}/{action=Index}/{id?}" // Then send them to the Blah controller with the action of Index. ID? means last argument nullable, or not required
                    );
            });
        }
    }
}
