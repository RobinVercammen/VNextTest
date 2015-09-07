using Microsoft.Framework.Configuration;
using Microsoft.Framework.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public static class Bindings
    {
        public static void AddCustomBindings(this IServiceCollection services, IConfiguration configuration)
        {
            IMongoClient client = new MongoClient(configuration.Get("ConnectionString"));
            services.AddInstance<IMongoClient>(client);
            services.AddInstance<IMongoDatabase>(client.GetDatabase("VnextDB"));
            services.AddScoped<ITimesheetService, TimesheetService>();
        }
    }
}
