using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSeekerRoleDTOS
{
   public  class JobSeekerRoleReturnDTO
    {
        public int JobSeekerRoleId { get; set; }
        public long JobSeekerId { get; set; }
        public int JobRoleId { get; set; }
    }
}


