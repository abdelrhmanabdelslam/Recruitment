using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Recruitment.Common.DotNet_Core_App;
using Recruitment.Common.Helper;
using Recruitment.ConfigureServicesContainer.AdminConfigureServices;

namespace AdminAPI
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
            services.ConfigureAdminServicesDI();

            ConfigHelper.Configuration = Configuration;
            services.Configure<AppSetting>(Configuration.GetSection("CommonSetting"));
            IOptions<AppSetting> settings = services.BuildServiceProvider().GetRequiredService<IOptions<AppSetting>>();
            ConfigHelper.AppSetting = settings.Value;

            services.Register(useSession: true);
            //services.Configure<AppSetting>(Configuration.GetSection("CommoneSetting"));
          
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new  Microsoft.OpenApi.Models.OpenApiInfo { Title = "BRG Recruitment API", Version = "v1" });

            });
            services.AddSwaggerDocument();
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
                app.UseHsts();
            }
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.Register(loggerFactory: null, useSession: true);
            //app.UseSwagger();
            app.UseSwaggerUi3();

        }
    }
}
