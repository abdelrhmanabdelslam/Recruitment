using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSeekerFieldOfStudyDTOS
{
   public  class JobSeekerFieldOfStudyUpdateDTO
    {
        public int JobSeekerFieldOfStudyId { get; set; }
        public string JobSeekerFieldOfStudyName { get; set; }
        public long JobSeekerId { get; set; }
    }
}


