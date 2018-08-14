using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Routing
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
            services.Configure<RouteOptions>(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //        name: "",
                //        template: "Static/{controller}/{action}/{id?}",
                //        defaults: new {controller = "Home", action="Index"}

                //    );
                //routes.MapRoute(
                //        name: "",
                //        template: "{controller}/{action}/{id?}/{*all}",
                //        defaults: new { controller = "Home", action = "index"}
                //    );

                //routes.MapRoute(
                //    name: "default",
                //    template: "{controller=Home}/{action=Index}/{id:int?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //routes.MapRoute(
                //    name: "default",
                //    // template: "{controller=Home}/{action=Index}/{id:regex([0-9]+$)?}");
                //    template: "{controller=Home}/{action=Index}/{id:alpha:minlength(2)?}");

                //routes.MapRoute(
                //        name: "",
                //        template: "{controller}/{action}/{id?}/{*all}",
                //        defaults: new { controller = "Home", action = "index" },
                //        constraints: new { id = new Microsoft.AspNetCore.Routing.Constraints.IntRouteConstraint() }
                //    );
            });
        }
    }
}
