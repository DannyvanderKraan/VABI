using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using VABI.Configuration;

namespace VABI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;

            var configurationBuilder = new ConfigurationBuilder();

            configurationBuilder.SetBasePath(env.ContentRootPath);

            configurationBuilder.AddJsonFile($@"Configuration\config.json");
            configurationBuilder.AddEnvironmentVariables();
            Configuration = configurationBuilder.Build();

        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<LegoCollectorCosmosDbSettings>(Configuration.GetSection("LegoCollectorCosmosDbSettings"));

            services.AddLegoCollectionServices();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
