using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class Employer
    {
        public Employer()
        {
            CompanyInformation = new HashSet<CompanyInformation>();
            EmployerJobRole = new HashSet<EmployerJobRole>();
        }

        public int EmployerId { get; set; }
        public int? CityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string MobileNumber { get; set; }
        public string MobileNumber1 { get; set; }
        public string BusinessEmail { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public byte? ReferralId { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }
        public virtual City City { get; set; }
        public virtual Referral Referral { get; set; }
        public virtual ICollection<CompanyInformation> CompanyInformation { get; set; }
        public virtual ICollection<EmployerJobRole> EmployerJobRole { get; set; }
    }
}
