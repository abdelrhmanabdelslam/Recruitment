using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class PostIndustry
    {
        public int PostIndustryId { get; set; }
        public int IndustryId { get; set; }
        public long? PostId { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan IsDeleted { get; set; }

        public virtual Post Post { get; set; }
    }
}
