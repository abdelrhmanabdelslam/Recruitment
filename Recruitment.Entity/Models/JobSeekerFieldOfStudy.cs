using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerFieldOfStudy
    {
        public int JobSeekerFieldOfStudyId { get; set; }
        public string JobSeekerFieldOfStudyName { get; set; }
        public long JobSeekerId { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan IsDeleted { get; set; }

        public virtual JobSeeker JobSeeker { get; set; }
    }
}
