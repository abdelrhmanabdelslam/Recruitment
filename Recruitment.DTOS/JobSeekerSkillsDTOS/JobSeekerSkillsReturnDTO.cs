using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSeekerSkillsDTOS
{
   public  class JobSeekerSkillsReturnDTO
    {
        public int JobSeekerSkillsId { get; set; }
        public long? JobSeekerId { get; set; }
        public string Skilles { get; set; }
    }
}


