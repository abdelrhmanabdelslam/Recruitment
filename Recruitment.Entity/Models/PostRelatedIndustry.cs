using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class PostRelatedIndustry
    {
        public int PostRelatedIndustryId { get; set; }
        public long? PostId { get; set; }
        public int? IndustryId { get; set; }
        public TimeSpan IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Industry Industry { get; set; }
        public virtual Post Post { get; set; }
    }
}
