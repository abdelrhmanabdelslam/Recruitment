using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Recruitment.Entity.Models
{
    public partial class RecruitmentContext : DbContext
    {
        public RecruitmentContext()
        {
        }

        public RecruitmentContext(DbContextOptions<RecruitmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CareerLevel> CareerLevel { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CompanyCoverImage> CompanyCoverImage { get; set; }
        public virtual DbSet<CompanyImage> CompanyImage { get; set; }
        public virtual DbSet<CompanyIndustry> CompanyIndustry { get; set; }
        public virtual DbSet<CompanyInformation> CompanyInformation { get; set; }
        public virtual DbSet<CompanyOnlinePresence> CompanyOnlinePresence { get; set; }
        public virtual DbSet<CompanySize> CompanySize { get; set; }
        public virtual DbSet<CompanyType> CompanyType { get; set; }
        public virtual DbSet<CompanyUser> CompanyUser { get; set; }
        public virtual DbSet<CompanyUserType> CompanyUserType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CurrentCareerLevel> CurrentCareerLevel { get; set; }
        public virtual DbSet<CurrentEducationalLevel> CurrentEducationalLevel { get; set; }
        public virtual DbSet<CurrentEducationalLevel> CurrentEducationalLevel1 { get; set; }
        public virtual DbSet<CurrentJobSearchStatus> CurrentJobSearchStatus { get; set; }
        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<EmployerJobRole> EmployerJobRole { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<Industry> Industry { get; set; }
        public virtual DbSet<JobRole> JobRole { get; set; }
        public virtual DbSet<JobSeeker> JobSeeker { get; set; }
        public virtual DbSet<JobSeekerApply> JobSeekerApply { get; set; }
        public virtual DbSet<JobSeekerApplyStatus> JobSeekerApplyStatus { get; set; }
        public virtual DbSet<JobSeekerExperience> JobSeekerExperience { get; set; }
        public virtual DbSet<JobSeekerFieldOfStudy> JobSeekerFieldOfStudy { get; set; }
        public virtual DbSet<JobSeekerGrade> JobSeekerGrade { get; set; }
        public virtual DbSet<JobSeekerProfessionalInformation> JobSeekerProfessionalInformation { get; set; }
        public virtual DbSet<JobSeekerRole> JobSeekerRole { get; set; }
        public virtual DbSet<JobSeekerSkills> JobSeekerSkills { get; set; }
        public virtual DbSet<JobSeekerTypeOfJob> JobSeekerTypeOfJob { get; set; }
        public virtual DbSet<JobSekeerLanguages> JobSekeerLanguages { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LanguageLevel> LanguageLevel { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostIndustry> PostIndustry { get; set; }
        public virtual DbSet<PostJobRole> PostJobRole { get; set; }
        public virtual DbSet<PostRelatedIndustry> PostRelatedIndustry { get; set; }
        public virtual DbSet<PostType> PostType { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }
        public virtual DbSet<TypeOfJob> TypeOfJob { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CareerLevel>(entity =>
            {
                entity.Property(e => e.CareerLevelId).ValueGeneratedOnAdd();

                entity.Property(e => e.CareerLevelName)
                    .IsRequired()
                    .HasColumnName("CareerLevelName")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountyId)
                    .HasConstraintName("FK_City_Country");
            });

            modelBuilder.Entity<CompanyCoverImage>(entity =>
            {
                entity.HasKey(e => e.ComapnyCoverImageId);

                entity.Property(e => e.ComapnyCoverImageUrl)
                    .IsRequired()
                    .HasColumnName("ComapnyCoverImageURL");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyInformation)
                    .WithMany(p => p.CompanyCoverImage)
                    .HasForeignKey(d => d.CompanyInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyCoverImage_CompanyInformation");
            });

            modelBuilder.Entity<CompanyImage>(entity =>
            {
                entity.Property(e => e.CompanyImgeUrl)
                    .IsRequired()
                    .HasColumnName("CompanyImgeURL");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyInformation)
                    .WithMany(p => p.CompanyImage)
                    .HasForeignKey(d => d.CompanyInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyImage_CompanyInformation");
            });

            modelBuilder.Entity<CompanyIndustry>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyInformation)
                    .WithMany(p => p.CompanyIndustry)
                    .HasForeignKey(d => d.CompanyInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyIndustry_CompanyInformation");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.CompanyIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyIndustry_Industry");
            });

            modelBuilder.Entity<CompanyInformation>(entity =>
            {
                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyPhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyWebsite)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.HasOne(d => d.CompanySize)
                    .WithMany(p => p.CompanyInformation)
                    .HasForeignKey(d => d.CompanySizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyInformation_CompanySize");

                entity.HasOne(d => d.CompanyType)
                    .WithMany(p => p.CompanyInformation)
                    .HasForeignKey(d => d.CompanyTypeId)
                    .HasConstraintName("FK_CompanyInformation_CompanyType");

                entity.HasOne(d => d.Employer)
                    .WithMany(p => p.CompanyInformation)
                    .HasForeignKey(d => d.EmployerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyInformation_Employer");
            });

            modelBuilder.Entity<CompanyOnlinePresence>(entity =>
            {
                entity.Property(e => e.Blog).HasMaxLength(500);

                entity.Property(e => e.Facebook).HasMaxLength(500);

                entity.Property(e => e.LinkedIn).HasMaxLength(500);

                entity.Property(e => e.Twitter).HasMaxLength(500);

                entity.HasOne(d => d.CompanyInformation)
                    .WithMany(p => p.CompanyOnlinePresence)
                    .HasForeignKey(d => d.CompanyInformationId)
                    .HasConstraintName("FK_CompanyOnlinePresence_CompanyInformation");
            });

            modelBuilder.Entity<CompanySize>(entity =>
            {
                entity.Property(e => e.CompanySizeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CompanySizeName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyType>(entity =>
            {
                entity.Property(e => e.CompanyTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyUser>(entity =>
            {
                entity.Property(e => e.CompanyUserId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CompanyInformation)
                    .WithMany(p => p.CompanyUser)
                    .HasForeignKey(d => d.CompanyInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyUser_CompanyInformation");

                entity.HasOne(d => d.CompanyUserType)
                    .WithMany(p => p.CompanyUser)
                    .HasForeignKey(d => d.CompanyUserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyUser_CompanyUserType");
            });

            modelBuilder.Entity<CompanyUserType>(entity =>
            {
                entity.Property(e => e.CompanyUserTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyUserTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CurrentCareerLevel>(entity =>
            {
                entity.Property(e => e.CurrentCareerLevelId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentCareerLevelName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CurrentEducationalLevel>(entity =>
            {
                entity.ToTable("CurrentEducational Level");

                entity.Property(e => e.CurrentEducationalLevelId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentEducationalLevelName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CurrentEducationalLevel>(entity =>
            {
                entity.HasKey(e => e.CurrentEducationalLevelId);

                entity.ToTable("CurrentEducationalLevel");

                entity.Property(e => e.CurrentEducationalLevelId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentEducationalLevelName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CurrentJobSearchStatus>(entity =>
            {
                entity.Property(e => e.CurrentJobSearchStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentJobSearchStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.Property(e => e.BusinessEmail).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.MobileNumber1).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(50);

                entity.Property(e => e.PasswordSalt).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Employer)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Employer_City");

                entity.HasOne(d => d.Referral)
                    .WithMany(p => p.Employer)
                    .HasForeignKey(d => d.ReferralId)
                    .HasConstraintName("FK_Employer_Referral");
            });

            modelBuilder.Entity<EmployerJobRole>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employer)
                    .WithMany(p => p.EmployerJobRole)
                    .HasForeignKey(d => d.EmployerId)
                    .HasConstraintName("FK_EmployerJobRole_Employer");

                entity.HasOne(d => d.JobRole)
                    .WithMany(p => p.EmployerJobRole)
                    .HasForeignKey(d => d.JobRoleId)
                    .HasConstraintName("FK_EmployerJobRole_JobRole");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.Property(e => e.GradeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.GradeName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IndustryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JobRole>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobRoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JobSeeker>(entity =>
            {
                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MinimumSalary).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.Property(e => e.University).HasMaxLength(500);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.JobSeeker)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_JobSeeker_City");

                entity.HasOne(d => d.CurrentCareerLevel)
                    .WithMany(p => p.JobSeeker)
                    .HasForeignKey(d => d.CurrentCareerLevelId)
                    .HasConstraintName("FK_JobSeeker_CurrentCareerLevel1");

                entity.HasOne(d => d.CurrentEducationalLevel)
                    .WithMany(p => p.JobSeeker)
                    .HasForeignKey(d => d.CurrentEducationalLevelId)
                    .HasConstraintName("FK_JobSeeker_CurrentEducational Level");

                entity.HasOne(d => d.CurrentJobSearchStatus)
                    .WithMany(p => p.JobSeeker)
                    .HasForeignKey(d => d.CurrentJobSearchStatusId)
                    .HasConstraintName("FK_JobSeeker_CurrentJobSearchStatus");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.JobSeeker)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK_JobSeeker_Grade");
            });

            modelBuilder.Entity<JobSeekerApply>(entity =>
            {
                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobSeekerApplyStatus)
                    .WithMany(p => p.JobSeekerApply)
                    .HasForeignKey(d => d.JobSeekerApplyStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerApply_JobSeekerApplyStatus");

                entity.HasOne(d => d.JobSeeker)
                    .WithMany(p => p.JobSeekerApply)
                    .HasForeignKey(d => d.JobSeekerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerApply_JobSeeker");
            });

            modelBuilder.Entity<JobSeekerApplyStatus>(entity =>
            {
                entity.Property(e => e.JobSeekerApplyStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobSeekerApplyStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<JobSeekerExperience>(entity =>
            {
                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.JobSeeker)
                    .WithMany(p => p.JobSeekerExperience)
                    .HasForeignKey(d => d.JobSeekerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerExperience_JobSeeker");

                entity.HasOne(d => d.TypeOfJob)
                    .WithMany(p => p.JobSeekerExperience)
                    .HasForeignKey(d => d.TypeOfJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerExperience_TypeOfJob");
            });

            modelBuilder.Entity<JobSeekerFieldOfStudy>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobSeekerFieldOfStudyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.JobSeeker)
                    .WithMany(p => p.JobSeekerFieldOfStudy)
                    .HasForeignKey(d => d.JobSeekerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerFieldOfStudy_JobSeeker");
            });

            modelBuilder.Entity<JobSeekerGrade>(entity =>
            {
                entity.Property(e => e.JobSeekerGradeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobSeekerGradeName).HasMaxLength(50);
            });

            modelBuilder.Entity<JobSeekerProfessionalInformation>(entity =>
            {
             
                
                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.JobSeekerProfessionalInformation)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK_JobSeekerProfessionalInformation_JobSeekerGrade");

                entity.HasOne(d => d.JobSeeker)
                    .WithMany(p => p.JobSeekerProfessionalInformation)
                    .HasForeignKey(d => d.JobSeekerId)
                    .HasConstraintName("FK_JobSeekerProfessionalInformation_JobSeeker");
            });

            modelBuilder.Entity<JobSeekerRole>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobRole)
                    .WithMany(p => p.JobSeekerRole)
                    .HasForeignKey(d => d.JobRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerRole_JobRole");

                entity.HasOne(d => d.JobSeeker)
                    .WithMany(p => p.JobSeekerRole)
                    .HasForeignKey(d => d.JobSeekerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerRole_JobSeeker");
            });

            modelBuilder.Entity<JobSeekerSkills>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Skilles).HasMaxLength(50);

                entity.HasOne(d => d.JobSeeker)
                    .WithMany(p => p.JobSeekerSkills)
                    .HasForeignKey(d => d.JobSeekerId)
                    .HasConstraintName("FK_JobSeekerSkills_JobSeeker");
            });

            modelBuilder.Entity<JobSeekerTypeOfJob>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobSeeker)
                    .WithMany(p => p.JobSeekerTypeOfJob)
                    .HasForeignKey(d => d.JobSeekerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerTypeOfJob_JobSeeker");

                entity.HasOne(d => d.TypeOfJob)
                    .WithMany(p => p.JobSeekerTypeOfJob)
                    .HasForeignKey(d => d.TypeOfJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSeekerTypeOfJob_TypeOfJob");
            });

            modelBuilder.Entity<JobSekeerLanguages>(entity =>
            {
                entity.HasKey(e => e.JobSeekerLanguagesId);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobSeeker)
                    .WithMany(p => p.JobSekeerLanguages)
                    .HasForeignKey(d => d.JobSeekerId)
                    .HasConstraintName("FK_JobSekeerLanguages_JobSeeker");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.JobSekeerLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSekeerLanguages_Language");

                entity.HasOne(d => d.LanguageLevel)
                    .WithMany(p => p.JobSekeerLanguages)
                    .HasForeignKey(d => d.LanguageLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSekeerLanguages_LanguageLevel");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LanguageLevel>(entity =>
            {
                entity.Property(e => e.LanguageLevelId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageLevelName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.AddationalSalary)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.SalaryFrom).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryTo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.YearsOfExperience)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CareerLevel)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.CareerLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Post_CareerLevel");

                entity.HasOne(d => d.PostType)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.PostTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Post_PostType");
            });

            modelBuilder.Entity<PostIndustry>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostIndustry)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_PostIndustry_Post");
            });

            modelBuilder.Entity<PostJobRole>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobRole)
                    .WithMany(p => p.PostJobRole)
                    .HasForeignKey(d => d.JobRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostJobRole_JobRole");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostJobRole)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostJobRole_Post");
            });

            modelBuilder.Entity<PostRelatedIndustry>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.PostRelatedIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .HasConstraintName("FK_PostRelatedIndustry_Industry");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostRelatedIndustry)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_PostRelatedIndustry_Post1");
            });

            modelBuilder.Entity<PostType>(entity =>
            {
                entity.Property(e => e.PostTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.PostTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Referral>(entity =>
            {
                entity.Property(e => e.ReferralId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ReferralName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeOfJob>(entity =>
            {
                entity.Property(e => e.TypeOfJobId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.TypeOfJobName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
