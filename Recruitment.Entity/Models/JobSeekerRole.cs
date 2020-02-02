using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerRole
    {
        public int JobSeekerRoleId { get; set; }
        public long JobSeekerId { get; set; }
        public int JobRoleId { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual JobRole JobRole { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
