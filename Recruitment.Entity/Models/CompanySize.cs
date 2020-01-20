using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanySize
    {
        public CompanySize()
        {
            CompanyInformation = new HashSet<CompanyInformation>();
        }

        public byte CompanySizeId { get; set; }
        public string CompanySizeName { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual ICollection<CompanyInformation> CompanyInformation { get; set; }
    }
}
