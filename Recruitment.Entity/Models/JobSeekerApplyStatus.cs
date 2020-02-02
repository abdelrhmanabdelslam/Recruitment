using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerApplyStatus
    {
        public JobSeekerApplyStatus()
        {
            JobSeekerApply = new HashSet<JobSeekerApply>();
        }

        public byte JobSeekerApplyStatusId { get; set; }
        public string JobSeekerApplyStatusName { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual ICollection<JobSeekerApply> JobSeekerApply { get; set; }
    }
}
