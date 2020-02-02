using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.EmployerDTOS
{
   public  class EmployerUpdateDTO
    {
        public byte EmployerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string MobileNumber { get; set; }
        public string MobileNumber1 { get; set; }
        public string BusinessEmail { get; set; }
        public string Password { get; set; }
        public byte? ReferralId { get; set; }
    }
}


