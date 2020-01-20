using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanyImage
    {
        public int CompanyImageId { get; set; }
        public int CompanyInformationId { get; set; }
        public string CompanyImgeUrl { get; set; }
        public bool IsMainPhoto { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual CompanyInformation CompanyInformation { get; set; }
    }
}
