using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using MongoDB.Driver;
using WebApi.Services;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.Runtime;

namespace WebApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            Configuration = new ConfigurationBuilder(appEnv.ApplicationBasePath).AddJsonFile("config.json").Build();
        }

        public IConfiguration Configuration { get; set; }
        // This method gets called by a runtime.
        // Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddInstance<IConfiguration>(Configuration);
            services.AddCustomBindings(Configuration);
            services.AddMvc();

            // CORS
            services.AddCors();

            var policy = new Microsoft.AspNet.Cors.Core.CorsPolicy();
            policy.Headers.Add("*");
            policy.Methods.Add("*");
            policy.Origins.Add("*");
            policy.SupportsCredentials = true;

            services.ConfigureCors(x => x.AddPolicy("mypolicy", policy));

            // Uncomment the following line to add Web API services which makes it easier to port Web API 2 controllers.
            // You will also need to add the Microsoft.AspNet.Mvc.WebApiCompatShim package to the 'dependencies' section of project.json.
            // services.AddWebApiConventions();
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Configure the HTTP request pipeline.
            app.UseStaticFiles();

            // CORS
            app.UseCors("mypolicy");

            // Add MVC to the request pipeline.
            app.UseMvc();
            // Add the following route for porting Web API 2 controllers.
            // routes.MapWebApiRoute("DefaultApi", "api/{controller}/{id?}");
        }
    }
}
