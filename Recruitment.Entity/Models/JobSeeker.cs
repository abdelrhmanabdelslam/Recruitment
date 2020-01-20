using System;
using System.Collections.Generic;

namespace Recruitment.Entity.Models
{
    public partial class JobSeeker
    {
        public JobSeeker()
        {
            JobSeekerApply = new HashSet<JobSeekerApply>();
            JobSeekerExperience = new HashSet<JobSeekerExperience>();
            JobSeekerFieldOfStudy = new HashSet<JobSeekerFieldOfStudy>();
            JobSeekerProfessionalInformation = new HashSet<JobSeekerProfessionalInformation>();
            JobSeekerRole = new HashSet<JobSeekerRole>();
            JobSeekerSkills = new HashSet<JobSeekerSkills>();
            JobSeekerTypeOfJob = new HashSet<JobSeekerTypeOfJob>();
            JobSekeerLanguages = new HashSet<JobSekeerLanguages>();
        }

        public long JobSeekerId { get; set; }
        public byte? CurrentCareerLevelId { get; set; }
        public byte? CurrentJobSearchStatusId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public int? CityId { get; set; }
        public decimal? MinimumSalary { get; set; }
        public bool? HideMySalary { get; set; }
        public bool? PublicProfile { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public byte? CurrentEducationalLevelId { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan IsDeleted { get; set; }
        public string University { get; set; }
        public int? GraduationYear { get; set; }
        public byte? GradeId { get; set; }

        public virtual City City { get; set; }
        public virtual CurrentCareerLevel CurrentCareerLevel { get; set; }
        public virtual CurrentEducationalLevel CurrentEducationalLevel { get; set; }
        public virtual CurrentJobSearchStatus CurrentJobSearchStatus { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<JobSeekerApply> JobSeekerApply { get; set; }
        public virtual ICollection<JobSeekerExperience> JobSeekerExperience { get; set; }
        public virtual ICollection<JobSeekerFieldOfStudy> JobSeekerFieldOfStudy { get; set; }
        public virtual ICollection<JobSeekerProfessionalInformation> JobSeekerProfessionalInformation { get; set; }
        public virtual ICollection<JobSeekerRole> JobSeekerRole { get; set; }
        public virtual ICollection<JobSeekerSkills> JobSeekerSkills { get; set; }
        public virtual ICollection<JobSeekerTypeOfJob> JobSeekerTypeOfJob { get; set; }
        public virtual ICollection<JobSekeerLanguages> JobSekeerLanguages { get; set; }
    }
}
