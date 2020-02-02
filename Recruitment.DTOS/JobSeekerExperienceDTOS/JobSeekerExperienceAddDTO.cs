using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSeekerExperienceDTOS
{
   public  class JobSeekerExperienceAddDTO
    {
    
        public long JobSeekerId { get; set; }
        public byte TypeOfJobId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public int? StartFromMonth { get; set; }
        public int? StartToMonth { get; set; }
        public int? EndToMonth { get; set; }
        public int? EndFromMonth1 { get; set; }
        public bool? IsCurrentJob { get; set; }
    }
}


