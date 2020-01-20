using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CompanyUser
    {
        public int CompanyUserId { get; set; }
        public int CompanyInformationId { get; set; }
        public byte CompanyUserTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JobTitile { get; set; }
        public bool IsAcceptInvitation { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual CompanyInformation CompanyInformation { get; set; }
        public virtual CompanyUserType CompanyUserType { get; set; }
    }
}
