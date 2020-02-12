using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.EmployerDTOS
{
    public class UserPasswordDTO
    {
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
