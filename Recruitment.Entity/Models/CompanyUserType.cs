using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanyUserType
    {
        public CompanyUserType()
        {
            CompanyUser = new HashSet<CompanyUser>();
        }

        public byte CompanyUserTypeId { get; set; }
        public string CompanyUserTypeName { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<CompanyUser> CompanyUser { get; set; }
    }
}
