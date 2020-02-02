using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSekeerLanguagesDTOS
{
   public  class JobSekeerLanguagesAddDTO
    {
      
        public long? JobSeekerId { get; set; }
        public byte LanguageId { get; set; }
        public byte LanguageLevelId { get; set; }
    }
}


