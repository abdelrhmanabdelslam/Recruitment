using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.Common.RequestHandler;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Common.Extensions
{
    public static class RecruitmentExtensions
    {
        public static IConfiguration Configuration { get; set; }
        public static AppSetting GetSetting(this IServiceCollection services, Components components)
        {
            // List<KeyValuePair<string, List<string>>> settingDict = null;
            AppSetting appSettingObj = null;
            try
            {
                string url = "https://localhost:44359/api/Setting?component=" + (byte)components;
                HTTPResponseJsonDTO<List<KeyValuePair<string, List<string>>>> response = RequestURL.HTTPRequest<List<KeyValuePair<string, List<string>>>>(url, RequestType.GET, null);
                //Convert dictionary response to appsetting Class
                appSettingObj = SettingHandler.GetSetting<AppSetting>(response.Body);
            }
            catch (System.Exception exception)
            {
                 
                appSettingObj = SettingHandler.GetSetting<AppSetting>(Configuration.GetSection("CommonSetting").Value);


            }
            ConfigHelper.AppSetting = appSettingObj;
            return appSettingObj;
        }


    }
}
