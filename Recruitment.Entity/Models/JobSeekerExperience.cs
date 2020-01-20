using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerExperience
    {
        public int JobSeekerExperienceId { get; set; }
        public long JobSeekerId { get; set; }
        public byte TypeOfJobId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public int? StartFromMonth { get; set; }
        public int? StartToMonth { get; set; }
        public int? EndToMonth { get; set; }
        public int? EndFromMonth1 { get; set; }
        public bool? IsCurrentJob { get; set; }

        public virtual JobSeeker JobSeeker { get; set; }
        public virtual TypeOfJob TypeOfJob { get; set; }
    }
}
