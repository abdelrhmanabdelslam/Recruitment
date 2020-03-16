using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recruitment.Common.Helper
{
    public class AppSetting
    {
        public string TokenSecurityKey { get; set; }
        public string TokenExpireInMinutes { get; set; }
        public string TDESKey { get; set; }
        public List<string> TokenSecurityKeyList { get { return TokenSecurityKey.Split(",").ToList(); } set { } }
        public List<string> TokenExpireInMinutesList { get { return TokenExpireInMinutes.Split(",").ToList(); } set { } }
        public List<string> TDESKeyList { get { return TDESKey.Split(",").ToList(); } set { } }
    }
}
