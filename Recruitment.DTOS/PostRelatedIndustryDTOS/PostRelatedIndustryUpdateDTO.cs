using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.PostRelatedIndustryDTOS
{
   public  class PostRelatedIndustryUpdateDTO
    {
        public int PostRelatedIndustryId { get; set; }
        public long? PostId { get; set; }
        public int? IndustryId { get; set; }
    }
}


