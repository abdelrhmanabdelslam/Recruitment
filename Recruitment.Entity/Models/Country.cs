using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
