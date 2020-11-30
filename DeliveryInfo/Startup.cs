using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DeliveryInfo.Data;
using DeliveryInfo.Models;
using DeliveryInfo.Pages.Delays;
using System.Net.Http;

namespace DeliveryInfo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddHttpClient("StopsAPI", c =>
                c.BaseAddress = new Uri(Configuration.GetValue<string>("StopsAPI"))
            );
            services.AddSingleton<Dates>();
            //services.AddSingleton<TrafficState>();
            services.AddScoped<TrafficState>();
            services.AddSingleton<ActivePageView>();
            services.AddSingleton<Rests>();
            services.AddSingleton<Delays>();
            services.AddSingleton<DelaysInfo>();
            services.AddSingleton<DelaysActive>();
            services.AddSingleton<DelaysTop10>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
