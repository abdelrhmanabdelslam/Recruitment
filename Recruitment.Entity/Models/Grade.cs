using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class Grade
    {
        public Grade()
        {
            JobSeeker = new HashSet<JobSeeker>();
        }

        public byte GradeId { get; set; }
        public string GradeName { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<JobSeeker> JobSeeker { get; set; }
    }
}
