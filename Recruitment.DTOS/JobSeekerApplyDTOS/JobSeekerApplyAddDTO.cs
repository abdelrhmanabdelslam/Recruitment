using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSeekerApplyDTOS
{
   public  class JobSeekerApplyAddDTO
    {
    
        public long PostId { get; set; }
        public long JobSeekerId { get; set; }
        public DateTime ApplyDate { get; set; }
        public byte JobSeekerApplyStatusId { get; set; }
    }
}


