using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class Industry
    {
        public Industry()
        {
            CompanyIndustry = new HashSet<CompanyIndustry>();
            PostRelatedIndustry = new HashSet<PostRelatedIndustry>();
        }

        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<CompanyIndustry> CompanyIndustry { get; set; }
        public virtual ICollection<PostRelatedIndustry> PostRelatedIndustry { get; set; }
    }
}
