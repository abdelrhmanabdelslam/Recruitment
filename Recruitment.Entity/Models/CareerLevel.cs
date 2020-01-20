using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class CareerLevel
    {
        public CareerLevel()
        {
            Post = new HashSet<Post>();
        }

        public byte CareerLevelId { get; set; }
        public string CareerLevelName { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
