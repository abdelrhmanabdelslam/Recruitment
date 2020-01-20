using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CurrentCareerLevel
    {
        public CurrentCareerLevel()
        {
            JobSeeker = new HashSet<JobSeeker>();
        }

        public byte CurrentCareerLevelId { get; set; }
        public string CurrentCareerLevelName { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual ICollection<JobSeeker> JobSeeker { get; set; }
    }
}
