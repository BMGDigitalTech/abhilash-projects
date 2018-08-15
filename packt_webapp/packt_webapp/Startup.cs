using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using packt_webapp.Entities;
using packt_webapp.Middlewares;
using packt_webapp.Repositories;

namespace packt_webapp
{
    public class MyConfiguration
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    public class Startup
    {

        public IConfigurationRoot Configuration { get;  }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();


            Debug.WriteLine($" ---> From Config: {Configuration["firstname"]}");
            Debug.WriteLine($" ---> From Config: {Configuration["withChild:option1"]}");
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            services.AddDbContext<PacktDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if(env.IsEnvironment("MyEnvironment"))
            {
                app.UseCustomMiddleWare();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCustomMiddleWare();
            app.UseMvc();
        }
    }
}
