using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.DTOS.JobSeekerDTOS
{
   public  class JobSeekerUpdateDTO
    {
        public long JobSeekerId { get; set; }
        public byte? CurrentCareerLevelId { get; set; }
        public byte? CurrentJobSearchStatusId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int? CityId { get; set; }
        public decimal? MinimumSalary { get; set; }
        public bool? HideMySalary { get; set; }
        public bool? PublicProfile { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public byte? CurrentEducationalLevelId { get; set; }
        public string University { get; set; }
        public int? GraduationYear { get; set; }
        public byte? GradeId { get; set; }
    }
}


