using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Common.Helper
{
    public static class SettingHandler
    {
        public static T GetSetting<T>(List<KeyValuePair<string, List<string>>> dict)
        {
            Type type = typeof(T);
            var obj = Activator.CreateInstance(type);

            foreach (var kv in dict)
            {
                type.GetProperty(kv.Key).SetValue(obj, kv.Value);
            }
            return (T)obj;
        }

        public static T GetSetting<T>( string dict)
        {
            return JsonConvert.DeserializeObject<T>(dict);

           
        }
    }
}
