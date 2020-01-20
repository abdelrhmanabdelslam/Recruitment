using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.EmployerDTOS
{
   public  class EmployerAddDTO
    {
     
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
    }
}


