using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.PostJobRoleDTOS
{
   public  class PostJobRoleUpdateDTO
    {
        public int PostJobRoleId { get; set; }
        public int JobRoleId { get; set; }
        public long PostId { get; set; }
    }
}


