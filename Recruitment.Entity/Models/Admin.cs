using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Entity.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

    }
}
