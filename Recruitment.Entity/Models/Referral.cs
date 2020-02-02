using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class Referral
    {
        public Referral()
        {
            Employer = new HashSet<Employer>();
        }

        public byte ReferralId { get; set; }
        public string ReferralName { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Employer> Employer { get; set; }
    }
}
