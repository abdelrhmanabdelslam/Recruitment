using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.CompanyUserDTOS
{
   public  class CompanyUserAddDTO
    {

        public int CompanyInformationId { get; set; }
        public byte CompanyUserTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JobTitile { get; set; }
        public bool IsAcceptInvitation { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsActive { get; set; }
    }
}


