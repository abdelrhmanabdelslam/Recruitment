using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class Language
    {
        public Language()
        {
            JobSekeerLanguages = new HashSet<JobSekeerLanguages>();
        }

        public byte LanguageId { get; set; }
        public string LanguageName { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<JobSekeerLanguages> JobSekeerLanguages { get; set; }
    }
}
