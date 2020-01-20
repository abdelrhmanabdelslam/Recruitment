using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanyType
    {
        public CompanyType()
        {
            CompanyInformation = new HashSet<CompanyInformation>();
        }

        public byte CompanyTypeId { get; set; }
        public string CompanyTypeName { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual ICollection<CompanyInformation> CompanyInformation { get; set; }
    }
}
