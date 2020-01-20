using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanyIndustry
    {
        public int CompanyIndustryId { get; set; }
        public int CompanyInformationId { get; set; }
        public int IndustryId { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual CompanyInformation CompanyInformation { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
