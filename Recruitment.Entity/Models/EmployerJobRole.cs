using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class EmployerJobRole
    {
        public int EmployerJobRoleId { get; set; }
        public int? EmployerId { get; set; }
        public int? JobRoleId { get; set; }
        public TimeSpan? IsDeleted { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Employer Employer { get; set; }
        public virtual JobRole JobRole { get; set; }
    }
}
