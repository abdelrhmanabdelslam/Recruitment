using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerGrade
    {
        public JobSeekerGrade()
        {
            JobSeekerProfessionalInformation = new HashSet<JobSeekerProfessionalInformation>();
        }

        public byte JobSeekerGradeId { get; set; }
        public string JobSeekerGradeName { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan IsDeleted { get; set; }

        public virtual ICollection<JobSeekerProfessionalInformation> JobSeekerProfessionalInformation { get; set; }
    }
}
