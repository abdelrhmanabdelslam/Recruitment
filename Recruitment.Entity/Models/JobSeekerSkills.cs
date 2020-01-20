using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerSkills
    {
        public int JobSeekerSkillsId { get; set; }
        public long? JobSeekerId { get; set; }
        public string Skilles { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan IsDeleted { get; set; }

        public virtual JobSeeker JobSeeker { get; set; }
    }
}
