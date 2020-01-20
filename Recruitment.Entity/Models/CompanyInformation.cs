using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanyInformation
    {
        public CompanyInformation()
        {
            CompanyCoverImage = new HashSet<CompanyCoverImage>();
            CompanyImage = new HashSet<CompanyImage>();
            CompanyIndustry = new HashSet<CompanyIndustry>();
            CompanyOnlinePresence = new HashSet<CompanyOnlinePresence>();
            CompanyUser = new HashSet<CompanyUser>();
        }

        public int CompanyInformationId { get; set; }
        public int EmployerId { get; set; }
        public byte? CompanyTypeId { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyName { get; set; }
        public string Fax { get; set; }
        public string CompanyPhone { get; set; }
        public byte CompanySizeId { get; set; }
        public int? YearFounded { get; set; }
        public string CompanyProfile { get; set; }
        public string Specialties { get; set; }
        public bool? IsStartupCompany { get; set; }
        public bool? IsMultinational { get; set; }
        public string Logo { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual CompanySize CompanySize { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        public virtual Employer Employer { get; set; }
        public virtual ICollection<CompanyCoverImage> CompanyCoverImage { get; set; }
        public virtual ICollection<CompanyImage> CompanyImage { get; set; }
        public virtual ICollection<CompanyIndustry> CompanyIndustry { get; set; }
        public virtual ICollection<CompanyOnlinePresence> CompanyOnlinePresence { get; set; }
        public virtual ICollection<CompanyUser> CompanyUser { get; set; }
    }
}
