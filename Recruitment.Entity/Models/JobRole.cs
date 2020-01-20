using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobRole
    {
        public JobRole()
        {
            EmployerJobRole = new HashSet<EmployerJobRole>();
            JobSeekerRole = new HashSet<JobSeekerRole>();
            PostJobRole = new HashSet<PostJobRole>();
        }

        public int JobRoleId { get; set; }
        public string JobRoleName { get; set; }
        public string Description { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<EmployerJobRole> EmployerJobRole { get; set; }
        public virtual ICollection<JobSeekerRole> JobSeekerRole { get; set; }
        public virtual ICollection<PostJobRole> PostJobRole { get; set; }
    }
}
