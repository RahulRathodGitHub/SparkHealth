using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Lapbase.Models;
using Lapbase.Services;
using Lapbase.LapbaseModels;

namespace Lapbase
{
    public class Startup
    {
        readonly string AllowAllOrigins = "AllowAllOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(AllowAllOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            services.AddTransient<PatientService>();
            services.AddTransient<TaskService>();
            services.AddTransient<AppointmentService>();

            services.AddDbContext<LapbaseNewContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("LapbaseNew")))
                    .AddDbContext<LapbaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Lapbase")));

            // Automatically perform database migration
            //services.BuildServiceProvider().GetService<LapbaseNewContext>().Database.Migrate();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors(AllowAllOrigins);
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
