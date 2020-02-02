using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSeekerTypeOfJobDTOS
{
   public  class JobSeekerTypeOfJobUpdateDTO
    {
        public int JobSeekerTypeOfJobId { get; set; }
        public long JobSeekerId { get; set; }
        public byte TypeOfJobId { get; set; }
    }
}


