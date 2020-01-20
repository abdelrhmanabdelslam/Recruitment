using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CurrentJobSearchStatus
    {
        public CurrentJobSearchStatus()
        {
            JobSeeker = new HashSet<JobSeeker>();
        }

        public byte CurrentJobSearchStatusId { get; set; }
        public string CurrentJobSearchStatusName { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual ICollection<JobSeeker> JobSeeker { get; set; }
    }
}
