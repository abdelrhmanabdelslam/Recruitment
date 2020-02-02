using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSekeerLanguagesDTOS
{
   public  class JobSekeerLanguagesUpdateDTO
    {
        public int JobSeekerLanguagesId { get; set; }
        public long? JobSeekerId { get; set; }
        public byte LanguageId { get; set; }
        public byte LanguageLevelId { get; set; }
    }
}


