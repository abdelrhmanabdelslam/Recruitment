using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerTypeOfJob
    {
        public int JobSeekerTypeOfJobId { get; set; }
        public long JobSeekerId { get; set; }
        public byte TypeOfJobId { get; set; }
        public TimeSpan IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual JobSeeker JobSeeker { get; set; }
        public virtual TypeOfJob TypeOfJob { get; set; }
    }
}
