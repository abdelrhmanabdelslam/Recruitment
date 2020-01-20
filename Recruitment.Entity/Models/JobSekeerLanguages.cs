using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSekeerLanguages
    {
        public int JobSeekerLanguagesId { get; set; }
        public long? JobSeekerId { get; set; }
        public byte LanguageId { get; set; }
        public byte LanguageLevelId { get; set; }
        public TimeSpan IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual JobSeeker JobSeeker { get; set; }
        public virtual Language Language { get; set; }
        public virtual LanguageLevel LanguageLevel { get; set; }
    }
}
