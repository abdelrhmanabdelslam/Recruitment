using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.CompanyOnlinePresenceDTOS
{
   public  class CompanyOnlinePresenceReturnDTO
    {
        public int CompanyOnlinePresenceId { get; set; }
        public int CompanyInformationId { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Blog { get; set; }
    }
}


