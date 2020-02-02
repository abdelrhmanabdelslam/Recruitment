using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class PostJobRole
    {
        public int PostJobRoleId { get; set; }
        public int JobRoleId { get; set; }
        public long PostId { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual JobRole JobRole { get; set; }
        public virtual Post Post { get; set; }
    }
}
