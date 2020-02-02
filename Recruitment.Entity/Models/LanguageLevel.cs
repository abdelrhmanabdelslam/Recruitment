using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class LanguageLevel
    {
        public LanguageLevel()
        {
            JobSekeerLanguages = new HashSet<JobSekeerLanguages>();
        }

        public byte LanguageLevelId { get; set; }
        public string LanguageLevelName { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual ICollection<JobSekeerLanguages> JobSekeerLanguages { get; set; }
    }
}
