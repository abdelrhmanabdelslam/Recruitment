
using Recruitment.Common.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Linq;
using System.Text;

namespace Recruitment.Common.DotNet_Core_App
{
    public static class APIRegisteration
    {
        public static IServiceCollection Register(this IServiceCollection services, bool useCORS = default(bool), bool useSession = default(bool), bool useToken = default(bool))
        {
            try
            {
                services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });
                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            }
            catch (System.Exception exception)
            {
                //Logger.Instance.WriteLog(logType: LogType.Error, methodBase: System.Reflection.MethodBase.GetCurrentMethod(), exception: exception);
            }
            return services;
        }
        public static IApplicationBuilder Register(this IApplicationBuilder app, ILoggerFactory loggerFactory, bool useCORS = default(bool), bool useSession = default(bool))
        {
            try
            {
                app.UseMvc(routes =>
                {
                    routes.MapRoute(
                      name: "Default",
                      template: "{controller=Home}/{action=Index}/{id?}"
                    );
                    routes.MapRoute(
                      name: "areas",
                      template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );
                });
                //app.UseHttpsRedirection();
                app.UseSwagger();
                app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });
            }
            catch (System.Exception exception)
            {
                //Logger.Instance.WriteLog(logType: LogType.Error, methodBase: System.Reflection.MethodBase.GetCurrentMethod(), exception: exception);
            }
            return app;
        }
    }
}
