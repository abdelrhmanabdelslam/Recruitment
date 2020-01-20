using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class City
    {
        public City()
        {
            Employer = new HashSet<Employer>();
            JobSeeker = new HashSet<JobSeeker>();
        }

        public int CityId { get; set; }
        public int? CountyId { get; set; }
        public string CityName { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Country County { get; set; }
        public virtual ICollection<Employer> Employer { get; set; }
        public virtual ICollection<JobSeeker> JobSeeker { get; set; }
    }
}
