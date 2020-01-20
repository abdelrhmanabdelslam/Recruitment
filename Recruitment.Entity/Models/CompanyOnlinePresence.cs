using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanyOnlinePresence
    {
        public int CompanyOnlinePresenceId { get; set; }
        public int? CompanyInformationId { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Blog { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }
        public virtual CompanyInformation CompanyInformation { get; set; }
    }
}
