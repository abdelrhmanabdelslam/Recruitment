using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerApply
    {
        public long JobSeekerApplyId { get; set; }
        public long PostId { get; set; }
        public long JobSeekerId { get; set; }
        public DateTime ApplyDate { get; set; }
        public byte JobSeekerApplyStatusId { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual JobSeeker JobSeeker { get; set; }
        public virtual JobSeekerApplyStatus JobSeekerApplyStatus { get; set; }
    }
}
