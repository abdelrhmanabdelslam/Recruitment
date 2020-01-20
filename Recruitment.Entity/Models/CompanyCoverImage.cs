using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanyCoverImage
    {
        public int ComapnyCoverImageId { get; set; }
        public int CompanyInformationId { get; set; }
        public string ComapnyCoverImageUrl { get; set; }
        public bool IsMainCover { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual CompanyInformation CompanyInformation { get; set; }
    }
}
