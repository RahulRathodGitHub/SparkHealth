using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;

using Lapbase.Models;
using Lapbase.Services;
using Lapbase.LapbaseModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Lapbase
{
    public class Startup
    {
        readonly string AllowAllOrigins = "AllowAllOrigins";

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            CurrentEnvironment = env;
        }

        public IConfiguration Configuration { get; }
        private IHostingEnvironment CurrentEnvironment { get; set; }

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
            services.AddTransient<TaskInputService>();
            services.AddTransient<AppointmentService>();
            services.AddTransient<ReportService>();

            services.AddDbContext<LapbaseNewContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("LapbaseNew")))
                    .AddDbContext<LapbaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Lapbase")));
            if (CurrentEnvironment.IsProduction())
            {
                // Automatically perform database migration
                services.BuildServiceProvider().GetService<LapbaseNewContext>().Database.Migrate();
            }

            //services
                //.AddAuthentication(AzureADDefaults.BearerAuthenticationScheme)
                //.AddAzureADBearer(options => Configuration.Bind("AzureAd", options));
                //.AddJwtBearer("azuread", options =>
                //    {
                //        options.Audience = Configuration.GetValue<string>("AzureAd:Audience");
                //        options.Authority = Configuration.GetValue<string>("AzureAd:instance") + Configuration.GetValue<string>("AzureAd:tenantid");
                //        options.TokenValidationParameters = new TokenValidationParameters
                //        {
                //            ValidIssuer = Configuration.GetValue<string>("AzureAd:issuer"),
                //            ValidAudience = Configuration.GetValue<string>("AzureAd:audience")
                //        };
                //    });

            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultScheme = AzureADDefaults.BearerAuthenticationScheme;
            })
            .AddAzureADBearer(options => Configuration.Bind("AzureAd", options));


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
