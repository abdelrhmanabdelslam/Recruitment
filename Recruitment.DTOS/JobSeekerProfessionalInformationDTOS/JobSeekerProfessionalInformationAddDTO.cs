using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSeekerProfessionalInformationDTOS
{
   public  class JobSeekerProfessionalInformationAddDTO
    {
   
        public long? JobSeekerId { get; set; }
        public byte? YearsOfExperience { get; set; }
        public byte? CurrentEducationalLevelId { get; set; }
        public string UniversityOrIstitution { get; set; }
        public int? GraduationYear { get; set; }
        public byte? GradeId { get; set; }
    }
}


