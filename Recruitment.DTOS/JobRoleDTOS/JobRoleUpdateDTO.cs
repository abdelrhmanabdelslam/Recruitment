using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobRoleDTOS
{
   public  class JobRoleUpdateDTO
    {
        public byte JobRoleId { get; set; }
        public string JobRoleName { get; set; }
        public string Description { get; set; }
    }
}


