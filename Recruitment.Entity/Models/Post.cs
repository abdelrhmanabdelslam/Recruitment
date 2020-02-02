using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class Post
    {
        public Post()
        {
            PostIndustry = new HashSet<PostIndustry>();
            PostJobRole = new HashSet<PostJobRole>();
            PostRelatedIndustry = new HashSet<PostRelatedIndustry>();
        }

        public long PostId { get; set; }
        public byte PostTypeId { get; set; }
        public int PostLocationId { get; set; }
        public string Area { get; set; }
        public byte CareerLevelId { get; set; }
        public string YearsOfExperience { get; set; }
        public decimal SalaryFrom { get; set; }
        public decimal SalaryTo { get; set; }
        public bool IsHideSalary { get; set; }
        public string AddationalSalary { get; set; }
        public byte NumberOfVacancies { get; set; }
        public string PostDescription { get; set; }
        public bool? IsClosed { get; set; }
        public DateTime CreationDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual CareerLevel CareerLevel { get; set; }
        public virtual PostType PostType { get; set; }
        public virtual ICollection<PostIndustry> PostIndustry { get; set; }
        public virtual ICollection<PostJobRole> PostJobRole { get; set; }
        public virtual ICollection<PostRelatedIndustry> PostRelatedIndustry { get; set; }
    }
}
