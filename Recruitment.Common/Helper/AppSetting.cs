using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Common.Helper
{
   public  class AppSetting
    {
        public List<string> TokenSecurityKey { get; set; }
        public List<string> TokenExpireInHours { get; set; }
        public List<string> RequestTimeoutInMiliseconds { get; set; }
        public List<string> TDESKey { get; set; }
    }
}
