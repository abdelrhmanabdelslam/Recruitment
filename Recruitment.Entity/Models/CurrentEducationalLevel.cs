using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CurrentEducationalLevel
    {
        public CurrentEducationalLevel()
        {
            JobSeeker = new HashSet<JobSeeker>();
        }

        public byte CurrentEducationalLevelId { get; set; }
        public string CurrentEducationalLevelName { get; set; }
        public byte  IsDeleted { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<JobSeeker> JobSeeker { get; set; }
    }
}
