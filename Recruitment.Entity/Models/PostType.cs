using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class PostType
    {
        public PostType()
        {
            Post = new HashSet<Post>();
        }

        public byte PostTypeId { get; set; }
        public string PostTypeName { get; set; }
        public TimeSpan IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
