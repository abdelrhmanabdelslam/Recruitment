using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class TypeOfJob
    {
        public TypeOfJob()
        {
            JobSeekerExperience = new HashSet<JobSeekerExperience>();
            JobSeekerTypeOfJob = new HashSet<JobSeekerTypeOfJob>();
        }

        public byte TypeOfJobId { get; set; }
        public string TypeOfJobName { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual ICollection<JobSeekerExperience> JobSeekerExperience { get; set; }
        public virtual ICollection<JobSeekerTypeOfJob> JobSeekerTypeOfJob { get; set; }
    }
}
