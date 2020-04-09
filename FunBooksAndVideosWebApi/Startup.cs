using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunBooksAndVideosWebApi.Entity;
using FunBooksAndVideosWebApi.Mapping;
using FunBooksAndVideosWebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FunBooksAndVideosWebApi
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
            services.AddControllers();
           
            services.AddScoped<IBusinessRules, ActivateMembership>();
            //services.AddSingleton<IBusinessRules, ShippingSlip>();
            services.AddScoped<IMembershipActivationService, ActivateMembershipService>();
            services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
            services.AddScoped<IMappingService, MappingService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
