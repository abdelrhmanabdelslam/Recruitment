using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeekerProfessionalInformation
    {
        public int? JobSeekerProfessionalInformationId { get; set; }
        public long? JobSeekerId { get; set; }
        public byte? YearsOfExperience { get; set; }
        public byte? CurrentEducationalLevelId { get; set; }
        public string UniversityOrIstitution { get; set; }
        public int? GraduationYear { get; set; }
        public byte? GradeId { get; set; }

        public virtual CurrentEducationalLevel CurrentEducationalLevel { get; set; }
        public virtual JobSeekerGrade Grade { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
